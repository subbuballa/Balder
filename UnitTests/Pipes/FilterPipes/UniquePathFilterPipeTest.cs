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
using de.ahzf.Pipes;

#endregion

namespace de.ahzf.Balder.UnitTests.FilterPipes
{

    [TestFixture]
    public class UniquePathFilterPipeTest
    {

        #region testAndPipeBasic()

        [Test]
        public void testUniquePathFilter()
        {
	
            var _Graph      = TinkerGraphFactory.CreateTinkerGraph();
            var _Pipe1      = new OutEdgesPipe <VertexId,    RevisionId, String, String, Object,
                                                EdgeId,      RevisionId, String, String, Object,
                                                MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>();

            var _Pipe2      = new InVertexPipe <VertexId,    RevisionId, String, String, Object,
                                                EdgeId,      RevisionId, String, String, Object,
                                                MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>();

            var _Pipe3      = new InEdgesPipe  <VertexId,    RevisionId, String, String, Object,
                                                EdgeId,      RevisionId, String, String, Object,
                                                MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>();

            var _Pipe4      = new OutVertexPipe<VertexId,    RevisionId, String, String, Object,
                                                EdgeId,      RevisionId, String, String, Object,
                                                MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>();

            var _Pipe5      = new UniquePathFilterPipe<IPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                                       EdgeId,      RevisionId, String, String, Object,
                                                                       MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>>();

            var _Pipeline   = new Pipeline<IPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                           EdgeId,      RevisionId, String, String, Object,
                                                           MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>,
                                           IPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                           EdgeId,      RevisionId, String, String, Object,
                                                           MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>>(_Pipe1, _Pipe2, _Pipe3, _Pipe4, _Pipe5);

            _Pipeline.SetSource(new SingleEnumerator<IPropertyVertex<VertexId,    RevisionId, String, String, Object,
                                                                     EdgeId,      RevisionId, String, String, Object,
                                                                     MultiEdgeId, RevisionId, String, String, Object,
                                                    HyperEdgeId, RevisionId, String, String, Object>>(_Graph.VertexById(new VertexId(1))));
	
            var _Counter = 0;
	
            foreach (var _Object in _Pipeline)
            {
                
                _Counter++;

                Assert.IsTrue(_Object.Equals(_Graph.VertexById(new VertexId(6))) ||
                              _Object.Equals(_Graph.VertexById(new VertexId(4))));

            }
	
            Assert.AreEqual(2, _Counter);
	
        }

        #endregion

    }

}
