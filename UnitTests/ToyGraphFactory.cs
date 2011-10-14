/*
 * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <code@ahzf.de>
 * This file is part of Blueprints.NET
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

using de.ahzf.Pipes;
using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraphs;
using de.ahzf.Blueprints.PropertyGraphs.InMemory.Mutable;

#endregion

namespace de.ahzf.Balder.UnitTests
{

    public static class ToyGraphFactory
    {

        public static IGenericPropertyGraph<VertexId,    RevisionId, String, String, Object,
                                            EdgeId,      RevisionId, String, String, Object,
                                            MultiEdgeId, RevisionId, String, String, Object,
                                            HyperEdgeId, RevisionId, String, String, Object> CreateToyGraph()
        {

            var _ToyGraph    = new DistributedPropertyGraph(new VertexId("ToyGraph"), null) as IGenericPropertyGraph<VertexId,    RevisionId, String, String, Object,
                                                                                                              EdgeId,      RevisionId, String, String, Object,
                                                                                                              MultiEdgeId, RevisionId, String, String, Object,
                                                                                                              HyperEdgeId, RevisionId, String, String, Object>;

            var _Alice       = _ToyGraph.AddVertex(new VertexId("1"), v => v.SetProperty("name", "Alice").    SetProperty("age", 29));
            var _Bob         = _ToyGraph.AddVertex(new VertexId("2"), v => v.SetProperty("name", "Bob").      SetProperty("age", 27));
            var _Carol       = _ToyGraph.AddVertex(new VertexId("3"), v => v.SetProperty("name", "Carol").    SetProperty("age", 23));
            var _Dave        = _ToyGraph.AddVertex(new VertexId("4"), v => v.SetProperty("name", "Dave").     SetProperty("age", 32));
            var _Eve         = _ToyGraph.AddVertex(new VertexId("5"), v => v.SetProperty("name", "Eve").      SetProperty("age", 12));
            var _Fred        = _ToyGraph.AddVertex(new VertexId("6"), v => v.SetProperty("name", "Fred").     SetProperty("age", 35));
            var _Geraldine   = _ToyGraph.AddVertex(new VertexId("7"), v => v.SetProperty("name", "Geraldine").SetProperty("age", 35));

            _ToyGraph.AddDoubleEdge(_Alice, _Bob,   new EdgeId("1a"), new EdgeId("1b"), "knows");
            _ToyGraph.AddDoubleEdge(_Alice, _Bob,   new EdgeId("2a"), new EdgeId("2b"), "loves");
            _ToyGraph.AddDoubleEdge(_Alice, _Carol, new EdgeId("3a"), new EdgeId("3b"), "knows");
            _ToyGraph.AddDoubleEdge(_Carol, _Dave,  new EdgeId("4a"), new EdgeId("4b"), "knows");

            _ToyGraph.AddEdge(_Carol, _Bob,   new EdgeId("5"),  "knows");
            _ToyGraph.AddEdge(_Carol, _Bob,   new EdgeId("6"),  "loves");
            _ToyGraph.AddEdge(_Dave,  _Carol, new EdgeId("7"),  "loves");
            _ToyGraph.AddEdge(_Eve,   _Alice, new EdgeId("8"),  "knows");
            _ToyGraph.AddEdge(_Eve,   _Alice, new EdgeId("9"),  "loves");
            _ToyGraph.AddEdge(_Eve,   _Alice, new EdgeId("10"), "spies");
            _ToyGraph.AddEdge(_Eve,   _Bob,   new EdgeId("11"), "knows");
            _ToyGraph.AddEdge(_Eve,   _Bob,   new EdgeId("12"), "spies");

            var a = _ToyGraph.V().OutE().ToList();

            // What are the names of Alice friends who are also friends with Bob?
            // gremlin> a.outE[[label:'kennt']].inV.outE[[label:'kennt']].inV[[id:'1']].back(4).Name
            // ==>Carol
            var AliceFriendsWithBob = _Alice.OutE("knows").InV().OutE("knows").InV();

            var Pipeline = new Pipeline<IPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                        EdgeId,      RevisionId, String, String, Object,
                                                        MultiEdgeId, RevisionId, String, String, Object,
                                                        HyperEdgeId, RevisionId, String, String, Object>,
                                        IPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                        EdgeId,      RevisionId, String, String, Object,
                                                        MultiEdgeId, RevisionId, String, String, Object,
                                                        HyperEdgeId, RevisionId, String, String, Object>>(
                               (v) => v.OutE("knows").InV().OutE("knows").InV());

            var _FirendFriends = Pipeline.SetSource(_Alice);

            // What's still missing?
            //  - OutE map filter
            //  - InV map filter
            //  - back(n)
            //  - Simple access of properties
            
            // just a test
            var xx = new { Name = "Alice", Alter = 18 };


            // What are Alice's friends’friends’ names who are not Bob's friends?
            // gremlin> x = []
            // gremlin> a.outE[[label:'kennt']].inV.aggregate(x).outE[[label:'kennt']].inV.except(x).Name
            // ==> Dave
            

            return _ToyGraph;

        }

    }

}
