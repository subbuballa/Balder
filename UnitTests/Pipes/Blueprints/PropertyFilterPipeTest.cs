/*
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
using System.Collections.Generic;

using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraphs;

using NUnit.Framework;
using de.ahzf.Styx;
using de.ahzf.Illias.Commons;

#endregion

namespace de.ahzf.Balder.UnitTests.Blueprints
{

    [TestFixture]
    public class PropertyFilterPipeTest
    {

        #region testPropertyFilter()

        [Test]
        public void testPropertyFilter()
        {

            var _Graph    = TinkerGraphFactory.CreateTinkerGraph();
            var _Marko    = _Graph.VertexById(new VertexId("1"));

            var _Pipe1    = new OutEdgesPipe<VertexId,    RevisionId, String, String, Object,
                                             EdgeId,      RevisionId, String, String, Object,
                                             MultiEdgeId, RevisionId, String, String, Object,
                                             HyperEdgeId, RevisionId, String, String, Object>();

            var _Pipe2    = new InVertexPipe<VertexId,    RevisionId, String, String, Object,
                                             EdgeId,      RevisionId, String, String, Object,
                                             MultiEdgeId, RevisionId, String, String, Object,
                                             HyperEdgeId, RevisionId, String, String, Object>();

            var _Pipe3    = new PropertyFilterPipe<VertexId, RevisionId, String, Object, IGenericPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                                                                                EdgeId,      RevisionId, String, String, Object,
                                                                                                                MultiEdgeId, RevisionId, String, String, Object,
                                                                                                                HyperEdgeId, RevisionId, String, String, Object>, String>("lang", "java", ComparisonFilter.NOT_EQUAL);

            var _Pipeline = new Pipeline<IGenericPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                                EdgeId,      RevisionId, String, String, Object,
                                                                MultiEdgeId, RevisionId, String, String, Object,
                                                                HyperEdgeId, RevisionId, String, String, Object>,

                                         IGenericPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                                EdgeId,      RevisionId, String, String, Object,
                                                                MultiEdgeId, RevisionId, String, String, Object,
                                                                HyperEdgeId, RevisionId, String, String, Object>>(new List<IPipe>() { _Pipe1, _Pipe2, _Pipe3 });

            _Pipeline.SetSource(new List<IGenericPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                                EdgeId,      RevisionId, String, String, Object,
                                                                MultiEdgeId, RevisionId, String, String, Object,
                                                                HyperEdgeId, RevisionId, String, String, Object>>() { _Marko }.GetEnumerator());

            var _Counter = 0;
            while (_Pipeline.MoveNext())
            {
                _Counter++;
                var _Vertex = _Pipeline.Current;
                Assert.AreEqual(new VertexId("3"), _Vertex.Id);
                Assert.AreEqual("java", _Vertex.GetProperty("lang"));
                Assert.AreEqual("lop",  _Vertex.GetProperty("name"));
            }

            Assert.AreEqual(1, _Counter);

        }

        #endregion

    }

}
