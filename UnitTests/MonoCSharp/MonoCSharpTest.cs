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

using NUnit.Framework;
using RunCSharp;
using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraph;

#endregion

namespace de.ahzf.Balder.UnitTests.MonoCSharp
{

    [TestFixture]
    public class MonoCSharpTest
    {
        
        #region BaseTest()

        [Test]
        public void BaseTest()
        {

            var _Compiler = new Runner();
            
            var a = _Compiler.Execute("Math.Abs(-42);");
            Assert.AreEqual(42, a);
            
            var b = _Compiler.Execute("class Fact { public int Run(int n) { return n <= 0 ? 1 : n*Run(n-1); } }");
            var c = _Compiler.Execute("new Fact().Run(5);");
            Assert.AreEqual(120, c);

            var d = _Compiler.Execute("\"abcdefgh\".Substring(1, 2);");
            Assert.AreEqual("bc", d);

            var e = _Compiler.Execute("var test = 123;");
            Assert.AreEqual("bc", e);


        }

        #endregion

    }

}
