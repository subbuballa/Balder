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

using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraphs;

using NUnit.Framework;

#endregion

namespace de.ahzf.Balder.UnitTests.Blueprints
{

    [TestFixture]
    public class LabelPipeTest
    {

        #region testLabels()

        [Test]
        public void testLabels()
        {

            var _Graph = TinkerGraphFactory.CreateTinkerGraph();
            
            var _Pipe  = new EdgeLabelPipe<VertexId,    RevisionId, String, String, Object,
                                           EdgeId,      RevisionId, String, String, Object,
                                           MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>();

            _Pipe.SetSourceCollection(_Graph.VertexById(new VertexId("1")).OutEdges());

            var _Counter = 0;
            while (_Pipe.MoveNext())
            {
                String label = _Pipe.Current;
                Assert.IsTrue(label.Equals("knows") || label.Equals("created"));
                _Counter++;
            }

            Assert.AreEqual(3, _Counter);

        }

        #endregion

    }

}
