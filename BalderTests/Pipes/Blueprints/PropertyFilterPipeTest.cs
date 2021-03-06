﻿/*
 * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <achim@graph-database.org>
 * This file is part of Balder <http://www.github.com/Vanaheimr/Balder>
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

using NUnit.Framework;

using de.ahzf.Vanaheimr.Styx;
using de.ahzf.Illias.Commons;
using de.ahzf.Illias.Commons.Collections;
using de.ahzf.Vanaheimr.Blueprints.UnitTests;
using de.ahzf.Vanaheimr.Blueprints;

#endregion

namespace de.ahzf.Vanaheimr.Balder.UnitTests.Blueprints
{

    [TestFixture]
    public class PropertyFilterPipeTest
    {

        #region testPropertyFilter()

        [Test]
        public void testPropertyFilter()
        {

            var _Graph    = TinkerGraphFactory.CreateTinkerGraph();
            var _Marko    = _Graph.VertexById(1);

            var _Pipe1    = new OutEdgesPipe<UInt64, Int64, String, String, Object,
                                             UInt64, Int64, String, String, Object,
                                             UInt64, Int64, String, String, Object,
                                             UInt64, Int64, String, String, Object>();

            var _Pipe2    = new InVertexPipe<UInt64, Int64, String, String, Object,
                                             UInt64, Int64, String, String, Object,
                                             UInt64, Int64, String, String, Object,
                                             UInt64, Int64, String, String, Object>();

            var _Pipe3    = new VertexPropertyFilterPipe<UInt64, Int64, String, String, Object,
                                                         UInt64, Int64, String, String, Object,
                                                         UInt64, Int64, String, String, Object,
                                                         UInt64, Int64, String, String, Object>("lang", v => v == "java");

            var _Pipeline = new Pipeline<IGenericPropertyVertex<UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object>,

                                         IGenericPropertyVertex<UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object>>(new List<IPipe>() { _Pipe1, _Pipe2, _Pipe3 });

            _Pipeline.SetSource(new List<IGenericPropertyVertex<UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object,
                                                                UInt64, Int64, String, String, Object>>() { _Marko }.GetEnumerator());

            var _Counter = 0;
            while (_Pipeline.MoveNext())
            {
                _Counter++;
                var _Vertex = _Pipeline.Current;
                Assert.AreEqual(3, _Vertex.Id);
                Assert.AreEqual("java", _Vertex.GetProperty("lang"));
                Assert.AreEqual("lop",  _Vertex.GetProperty("name"));
            }

            Assert.AreEqual(1, _Counter);

        }

        #endregion

    }

}
