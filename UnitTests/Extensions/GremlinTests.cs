﻿/*
 * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <code@ahzf.de>
 * This file is part of Pipes.NET <http://www.github.com/ahzf/pipes.NET>
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
using System.Collections.Generic;

using NUnit.Framework;

using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraph;

using de.ahzf.BlueprintPipes.ExtensionMethods;

#endregion

namespace de.ahzf.BlueprintPipes.UnitTests.Pipes
{

    [TestFixture]
    public class GremlinTests
    {

        #region Gremlin01()

        [Test]
        public void Gremlin01()
        {

            var _ToyGraph = ToyGraphFactory.CreateToyGraph();

            var _AllEdges01 = _ToyGraph.V().OutE().ToList();
            var _AllEdges02 = _ToyGraph.V().OutE("loves").ToList();

            var a = _ToyGraph.GetVertex(new VertexId(1)).OutE("knows");

        }

        #endregion

    }

}