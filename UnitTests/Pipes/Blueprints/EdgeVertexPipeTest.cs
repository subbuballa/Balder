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

using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraphs;

using NUnit.Framework;
using de.ahzf.Styx;
using de.ahzf.Illias.Commons;

#endregion

namespace de.ahzf.Balder.UnitTests.Blueprints
{

    [TestFixture]
    public class EdgeVertexPipeTest
    {

        #region testInCommingVertex()

        [Test]
        public void testInCommingVertex()
        {

            var _Graph = TinkerGraphFactory.CreateTinkerGraph();

            var _Marko = _Graph.VertexById(new VertexId("1"));

            var _EVP   = new InVertexPipe<VertexId,    RevisionId, String, String, Object,
                                          EdgeId,      RevisionId, String, String, Object,
                                          MultiEdgeId, RevisionId, String, String, Object,
                                          HyperEdgeId, RevisionId, String, String, Object>();

            _EVP.SetSourceCollection(_Marko.OutEdges());

            var _Counter = 0;
            while (_EVP.MoveNext())
            {
                var v = _EVP.Current;
                Assert.IsTrue(v.Id.Equals(new VertexId("2")) || v.Id.Equals(new VertexId("3")) || v.Id.Equals(new VertexId("4")));
                _Counter++;
            }

            Assert.AreEqual(3, _Counter);


            var _Josh = _Graph.VertexById(new VertexId("4"));
            
            _EVP = new InVertexPipe<VertexId,    RevisionId, String, String, Object,
                                    EdgeId,      RevisionId, String, String, Object,
                                    MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>();

            _EVP.SetSource(_Josh.OutEdges().GetEnumerator());

            _Counter = 0;
            while (_EVP.MoveNext())
            {
                var v = _EVP.Current;
                Assert.IsTrue(v.Id.Equals(new VertexId("5")) || v.Id.Equals(new VertexId("3")));
                _Counter++;
            }

            Assert.AreEqual(2, _Counter);

            Assert.IsFalse(_EVP.MoveNext());

        }

        #endregion

        #region testBothVertices()

        [Test]
        public void testBothVertices()
        {

            var _Graph = TinkerGraphFactory.CreateTinkerGraph();

            var _Josh  = _Graph.VertexById(new VertexId("4"));
            IGenericPropertyEdge<VertexId,    RevisionId, String, String, Object,
                                 EdgeId,      RevisionId, String, String, Object,
                                 MultiEdgeId, RevisionId, String, String, Object,
                                 HyperEdgeId, RevisionId, String, String, Object> _TmpEdge = null;

            foreach (var _Edge in _Josh.OutEdges())
            {
                if (_Edge.Id.Equals(new VertexId("11")))
                    _TmpEdge = _Edge;
            }

            var _Pipe = new BothVerticesPipe<VertexId,    RevisionId, String, String, Object,
                                             EdgeId,      RevisionId, String, String, Object,
                                             MultiEdgeId, RevisionId, String, String, Object,
                                             HyperEdgeId, RevisionId, String, String, Object>();

            _Pipe.SetSource(new SingleEnumerator<IGenericPropertyEdge<VertexId,    RevisionId, String, String, Object,
                                                                      EdgeId,      RevisionId, String, String, Object,
                                                                      MultiEdgeId, RevisionId, String, String, Object,
                                                                      HyperEdgeId, RevisionId, String, String, Object>>(_TmpEdge));

            var _Counter = 0;
            while (_Pipe.MoveNext())
            {
                _Counter++;
                var _Vertex = _Pipe.Current;
                Assert.IsTrue(_Vertex.Id.Equals(new VertexId("4")) || _Vertex.Id.Equals(new VertexId("3")));
            }

            Assert.AreEqual(2, _Counter);

        }

        #endregion

    }

}
