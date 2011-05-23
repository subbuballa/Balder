///*
// * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <code@ahzf.de>
// * This file is part of BlueprintPipes.NET <http://www.github.com/ahzf/BlueprintPipes.NET>
// *
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// *
// *     http://www.apache.org/licenses/LICENSE-2.0
// *
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// */

#region Usings

using System;
using System.Linq;

using Mono;
using Mono.CSharp;
using RunCSharp;

using de.ahzf.Blueprints;
using de.ahzf.Blueprints.PropertyGraph;
using de.ahzf.Blueprints.PropertyGraph.InMemory;
using de.ahzf.Pipes;
using de.ahzf.BlueprintPipes.ExtensionMethods;

#endregion

namespace de.ahzf.MonoCompilerAsAService
{

    public class Program
    {

        private static Runner _Compiler;

        public static void Main(String[] myArgs)
        {

            #region Feel free to step through...

            _Compiler = new Runner();
            var a = _Compiler.Execute("Math.Abs(-42);");
            var b = _Compiler.Execute("Math.Sin(Math.PI / 6);");
            var c = _Compiler.Execute("class Fact { public int Run(int n) { return n <= 0 ? 1 : n*Run(n-1); } }");
            var d = _Compiler.Execute("new Fact().Run(5);");
            var e = _Compiler.Execute("\"abcdefgh\".Substring(1, 2);");
            var f = _Compiler.Execute("class Echo { public Object Print(Object o) { return o; } }");
            var g = _Compiler.Execute("var test = 123;");
            var h = _Compiler.Execute("new Echo().Print(test);");

            #endregion

            #region Start the interactive (read-eval-print loop) shell...

            var _Report = new Report(new ConsoleReportPrinter());
            var _CLP = new CommandLineParser(_Report);
            _CLP.UnknownOptionHandler += Mono.Driver.HandleExtraArguments;

            var _Settings = _CLP.ParseArguments(myArgs);
            if (_Settings == null || _Report.Errors > 0)
                Environment.Exit(1);

            var _Evaluator = new Evaluator(_Settings, _Report)
            {
                InteractiveBaseClass = typeof(InteractiveBaseShell),
                DescribeTypeExpressions = true
            };

            //// Adding a assembly twice will lead to delayed errors...
            //_Evaluator.ReferenceAssembly(typeof(YourAssembly).Assembly);

            var _CSharpShell = new CSharpShell(_Evaluator, "BluePipes").Run();

            #endregion

        }

    }

}
