﻿/*
 * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <code@ahzf.de>
 * This file is part of Balder <http://www.github.com/ahzf/Balder>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#region Usings

using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraph;
using de.ahzf.Blueprints.PropertyGraph.InMemory;

#endregion

namespace de.ahzf.Tutorials
{

    /// <summary>
    /// A SmallBenchmark
    /// Do not trust any benchmark you did not manipulate yourself ;)!
    /// </summary>
    public class SmallBenchmark
    {

        #region VertexTypes

        /// <summary>
        /// The vertex types
        /// </summary>
        public enum VertexType
        {
            Tag,
            Website
        }

        #endregion

        #region Vertex properties

        /// <summary>
        /// The type property
        /// </summary>
        public const String _Type = "Type";

        /// <summary>
        /// The name property
        /// </summary>
        public const String _Name = "Name";

        /// <summary>
        /// The Url property
        /// </summary>
        public const String _Url = "Url";

        #endregion

        #region TagLabel

        /// <summary>
        /// The tag label
        /// </summary>
        public const String _TagLabel = "tag";

        #endregion


        #region SmallBenchmark()

        /// <summary>
        /// A SmallBenchmark
        /// Do not trust any benchmark you did not manipulate yourself ;)!
        /// </summary>
        public SmallBenchmark()
        {

            var Stopwatch = new Stopwatch();
                        var PRNG = new Random();

            // Create a new simple property graph
            var _graph = new SimplePropertyGraph();

            var NumberOfUsers           = 200000UL;
            var NumberOfIterations      = 30;
            var MinNumberOfEdges        = 15;
            var MaxNumberOfEdges        = 25;

            var CountedNumberOfEdges    = 0UL;


            var d = new Dictionary<UInt64, UInt64>();
            for (var i = 0UL; i < NumberOfUsers; i++)
            {
                d.Add(i, i);
            }

            Stopwatch.Restart();
            foreach (var INT in d)
                CountedNumberOfEdges += INT.Value;
            Stopwatch.Stop();
            Console.WriteLine(Stopwatch.Elapsed.TotalMilliseconds + "ms");

            Stopwatch.Restart();
            var b = new UInt64[NumberOfUsers];
            foreach (var INT in b)
                CountedNumberOfEdges += INT;
            Stopwatch.Stop();
            Console.WriteLine(Stopwatch.Elapsed.TotalMilliseconds + "ms");




            IPropertyVertex<UInt64, Int64,         String, Object,
                            UInt64, Int64, String, String, Object,
                            UInt64, Int64, String, String, Object> ActualVertex = null;

            var Vertices = new IPropertyVertex<UInt64, Int64,         String, Object,
                                               UInt64, Int64, String, String, Object,
                                               UInt64, Int64, String, String, Object>[NumberOfUsers+1];

            var Measurements = new Double[NumberOfIterations];
            
            Stopwatch.Start();

            Vertices[0] = _graph.AddVertex(1);

            for (var VertexId = 2UL; VertexId < NumberOfUsers; VertexId++)
            {

                ActualVertex = _graph.AddVertex(VertexId, v => v.SetProperty("Name", "User" + VertexId)
                                                                .SetProperty("Age",  PRNG.Next(0, 150)));
                Vertices[VertexId-1] = ActualVertex;
                _graph.AddEdge(ActualVertex, Vertices[PRNG.Next(0, (Int32) VertexId-1)]);

                var NumberOfAdditionalEdges = (UInt64) PRNG.Next(MinNumberOfEdges, MaxNumberOfEdges);

                do
                {
                    _graph.AddEdge(ActualVertex, Vertices[PRNG.Next(0, (Int32) VertexId - 1)]);
                } while (ActualVertex.OutDegree() < NumberOfAdditionalEdges);

                if (VertexId % 10000UL == 0)
                    Console.WriteLine(VertexId);

            }

            Stopwatch.Stop();
            Console.WriteLine("Creation Time: " + Stopwatch.Elapsed.TotalMilliseconds + "ms");
            Console.WriteLine();



            for (var Iteration = 0; Iteration < NumberOfIterations; Iteration++)
            {

                CountedNumberOfEdges = 0;

                Stopwatch.Restart();

                foreach (var _Vertex in _graph.Vertices())
                {
                    CountedNumberOfEdges += (UInt64) _Vertex.OutDegree();
                }

                Stopwatch.Stop();
                Measurements[Iteration] = Stopwatch.Elapsed.TotalMilliseconds;
                Console.WriteLine(CountedNumberOfEdges + " edges in " + Stopwatch.Elapsed.TotalMilliseconds + "ms");

            }

            var AverageAndStdDev = Measurements.AverageAndStdDev();
            Console.WriteLine("Mean: " + AverageAndStdDev.Item1 + ", stddev: " + AverageAndStdDev.Item2);
            Console.ReadLine();

        }

        #endregion

    }

}
