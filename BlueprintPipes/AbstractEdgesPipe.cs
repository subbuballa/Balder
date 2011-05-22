/*
 * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <code@ahzf.de>
 * This file is part of BlueprintPipes.NET <http://www.github.com/ahzf/BlueprintPipes.NET>
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

using de.ahzf.Blueprints.PropertyGraph;
using System.Collections.Generic;

#endregion

namespace de.ahzf.Pipes
{

    /// <summary>
    /// AbstractEdgesPipe.
    /// </summary>
    public abstract class AbstractEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>
                                            
                                            : AbstractPipe<
                                                 IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                 TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                 TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>,
                                                 IPropertyEdge  <TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                 TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                 TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>

        where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
        where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
        where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

        where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
        where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
        where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

        where TEdgeLabel              : IEquatable<TEdgeLabel>,           IComparable<TEdgeLabel>,           IComparable
        where THyperEdgeLabel         : IEquatable<THyperEdgeLabel>,      IComparable<THyperEdgeLabel>,      IComparable

        where TRevisionIdVertex       : IEquatable<TRevisionIdVertex>,    IComparable<TRevisionIdVertex>,    IComparable, TValueVertex
        where TRevisionIdEdge         : IEquatable<TRevisionIdEdge>,      IComparable<TRevisionIdEdge>,      IComparable, TValueEdge
        where TRevisionIdHyperEdge    : IEquatable<TRevisionIdHyperEdge>, IComparable<TRevisionIdHyperEdge>, IComparable, TValueHyperEdge
    {

        #region Data

        /// <summary>
        /// The label of the edge(s) to follow.
        /// </summary>
        protected TEdgeLabel _Label;

        /// <summary>
        /// If the EdgeLabel is in use, as _Label is always at least default(TEdgeLabel)!
        /// </summary>
        protected Boolean _UseLabel;


        /// <summary>
        /// Edges to be traversed next...
        /// </summary>
        protected IEnumerator<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> _NextEdges;

        #endregion

        #region Constructor(s)

        #region AbstractEdgesPipe(IEnumerable, IEnumerator)

        /// <summary>
        /// Creates a new AbstractEdgesPipe.
        /// </summary>
        /// <param name="IEnumerable">An IEnumerable&lt;...&gt; as element source.</param>
        /// <param name="IEnumerator">An IEnumerator&lt;...&gt; as element source.</param>
        public AbstractEdgesPipe(IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,
                                 IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)
            : base(IEnumerable, IEnumerator)
        {
            _Label    = default(TEdgeLabel);
            _UseLabel = false;
        }

        #endregion

        #region AbstractEdgesPipe(Label, IEnumerable, IEnumerator)

        /// <summary>
        /// Creates a new AbstractEdgesPipe for traversing all
        /// edges having the given EdgeLabel.
        /// </summary>
        /// <param name="Label">The EdgeLabel to traverse.</param>
        /// <param name="IEnumerable">An IEnumerable&lt;...&gt; as element source.</param>
        /// <param name="IEnumerator">An IEnumerator&lt;...&gt; as element source.</param>
        public AbstractEdgesPipe(TEdgeLabel Label,
                                 IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,
                                 IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)
            : base(IEnumerable, IEnumerator)
        {
            _Label    = Label;
            _UseLabel = true;
        }

        #endregion

        #endregion


        #region Reset()

        /// <summary>
        /// A pipe may maintain state. Reset is used to remove state.
        /// </summary>
        public override void Reset()
        {            
            _NextEdges = null;
            base.Reset();
        }

        #endregion

        #region ToString()

        /// <summary>
        /// A string representation of this pipe.
        /// </summary>
        public override String ToString()
        {

            if (_UseLabel)
                return base.ToString() + "(" + _Label + ")";

            return base.ToString();

        }

        #endregion

    }

}
