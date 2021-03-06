![Balder logo](/ahzf/Balder/raw/master/doc/BlueprintPipes.NET-logo.png)

[Balder](http://github.com/Vanaheimr/Balder) is a data flow framework for
[property graph models](http://github.com/tinkerpop/gremlin/wiki/Defining-a-Property-Graph)
based on [Styx](http://github.com/Vanaheimr/Styx) and written in .NET/Mono. It comes with some
syntactic sugar to build a powerful "LINQ to graphs" interface. A process graph is composed of
a set of process vertices connected to one another by a set of communication edges. Pipes supports
the splitting, merging, and transformation of data from input to output. Balder is for .NET what
[Gremlin](http://github.com/tinkerpop/gremlin) is for [Groovy](http://groovy.codehaus.org) or
[Pacer](http://github.com/pangloss/pacer) is for [JRuby](http://jruby.org).

#### Usage

[Balder](http://github.com/Vanaheimr/Balder) comes with some syntactic sugar to make coexistence
with LINQ a bit easier.

    var _Friends = _Graph.V().
                   OutE("knows").
                   InV().
                   Prop("name");

    _Friends.ForEach(_Friend => Console.WriteLine(_Friend));

...which is in detail equivalent to the following standard syntax:

    var _Pipe1    = new VertexEdgePipe(VertexEdgePipe.Step.OUT_EDGES);
    var _Pipe2    = new LabelFilterPipe("knows", ComparisonFilter.NOT_EQUAL);
    var _Pipe3    = new EdgeVertexPipe(EdgeVertexPipe.Step.IN_VERTEX);
    var _Pipe4    = new VertexPropertyPipe<String>("name");
    var _Pipeline = new Pipeline<IVertex,String>(_Pipe1, _Pipe2, _Pipe3, _Pipe4);
    _Pipeline.SetSource(new SingleEnumerator<IVertex>(_Graph.GetVertex(new VertexId(1)));
    foreach (var _Friend in _Pipeline)
    {
        Console.WriteLine(_Friend);
    }

#### Help and Documentation

Additional help and much more examples can be found in the [Wiki](http://github.com/Vanaheimr/Balder/wiki).   
News and updates can also be found on twitter by following: [@ahzf](http://www.twitter.com/ahzf) or [@graphdbs](http://www.twitter.com/graphdbs).

#### Installation

The installation of Balder is very straightforward.    
Just check out or download its sources and all its dependencies:

- [Blueprints.NET](http://github.com/Vanaheimr/Blueprints.NET) for the handling of property graphs
- [Styx](http://github.com/Vanaheimr/Styx) a both a lazy and an event-based data flow framework. 
- [NUnit](http://www.nunit.org/) for unit tests

If you are interessted in using the [PipesShell](http://github.com/Vanaheimr/Styx/wiki/PipesShell-for-Adhoc-Graph-Querying) you have to add the latest [Mono.CSharp](http://tirania.org/blog/archive/2011/Feb-24.html) library (2011-02-28).

#### License and your contribution

[Balder](http://github.com/Vanaheimr/Balder) is released under the [Apache License 2.0](http://www.apache.org/licenses/LICENSE-2.0). For details see the [LICENSE](/Vanaheimr/Balder/blob/master/LICENSE) file.    
To suggest a feature, report a bug or general discussion: [http://github.com/Vanaheimr/Balder/issues](http://github.com/Vanaheimr/Balder/issues)    
If you want to help or contribute source code to this project, please use the same license.   
The coding standards can be found by reading the code ;)

#### Acknowledgments

[Balder](http://github.com/Vanaheimr/Balder) is to some extent a reimplementation of the [Pipes](http://github.com/tinkerpop/pipes) library for Java provided by [Tinkerpop](http://tinkerpop.com).    
Please read the [NOTICE](/Vanaheimr/Balder/blob/master/NOTICE) file for further credits.

#### 


