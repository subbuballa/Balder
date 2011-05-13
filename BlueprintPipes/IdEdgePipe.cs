﻿/*
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
using System.Collections.Generic;

using de.ahzf.blueprints.PropertyGraph;
using de.ahzf.blueprints.GenericGraph;

#endregion

namespace de.ahzf.Pipes
{

    /// <summary>
    /// The IdEdgePipe will convert the given EdgeIds into the
    /// corresponding edges of the given graph.
    /// </summary>
    public class IdEdgePipe<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,    TDatastructureVertex,    TVertexExchange,
                            TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,      TDatastructureEdge,      TEdgeExchange,
                            TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge, TDatastructureHyperEdge, THyperEdgeExchange>

                            : AbstractPipe<TIdEdge, IPropertyEdge<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,
                                                                  TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,
                                                                  TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge>>

        where TDatastructureVertex    : IDictionary<TKeyVertex,    TValueVertex>
        where TDatastructureEdge      : IDictionary<TKeyEdge,      TValueEdge>
        where TDatastructureHyperEdge : IDictionary<TKeyHyperEdge, TValueHyperEdge>

        where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
        where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
        where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable
                                                                                                            
        where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
        where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
        where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

        where TRevisionIdVertex       : IEquatable<TRevisionIdVertex>,    IComparable<TRevisionIdVertex>,    IComparable, TValueVertex
        where TRevisionIdEdge         : IEquatable<TRevisionIdEdge>,      IComparable<TRevisionIdEdge>,      IComparable, TValueEdge
        where TRevisionIdHyperEdge    : IEquatable<TRevisionIdHyperEdge>, IComparable<TRevisionIdHyperEdge>, IComparable, TValueHyperEdge

        where TVertexExchange         : IGenericVertex   <TIdVertex,    TRevisionIdVertex,    IProperties<TKeyVertex,    TValueVertex>,
                                                          TIdEdge,      TRevisionIdEdge,      IProperties<TKeyEdge,      TValueEdge>,
                                                          TIdHyperEdge, TRevisionIdHyperEdge, IProperties<TKeyHyperEdge, TValueHyperEdge>>

        where TEdgeExchange           : IGenericEdge     <TIdVertex,    TRevisionIdVertex,    IProperties<TKeyVertex,    TValueVertex>,
                                                          TIdEdge,      TRevisionIdEdge,      IProperties<TKeyEdge,      TValueEdge>,
                                                          TIdHyperEdge, TRevisionIdHyperEdge, IProperties<TKeyHyperEdge, TValueHyperEdge>>

        where THyperEdgeExchange      : IGenericHyperEdge<TIdVertex,    TRevisionIdVertex,    IProperties<TKeyVertex,    TValueVertex>,
                                                          TIdEdge,      TRevisionIdEdge,      IProperties<TKeyEdge,      TValueEdge>,
                                                          TIdHyperEdge, TRevisionIdHyperEdge, IProperties<TKeyHyperEdge, TValueHyperEdge>>

    {

        #region Data

        private readonly IPropertyGraph<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,    TDatastructureVertex,
                                        TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,      TDatastructureEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge, TDatastructureHyperEdge> _IPropertyGraph;

        #endregion

        #region Constructor(s)

        #region IdEdgePipe(myIPropertyGraph)

        /// <summary>
        /// Creates a new IdEdgePipe.
        /// </summary>
        /// <param name="myIPropertyGraph">The IPropertyGraph to use.</param>
        public IdEdgePipe(IPropertyGraph<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,    TDatastructureVertex,
                                         TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,      TDatastructureEdge,
                                         TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge, TDatastructureHyperEdge> myIPropertyGraph)
        {
            _IPropertyGraph = myIPropertyGraph;
        }

        #endregion

        #endregion


        #region MoveNext()

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>
        /// True if the enumerator was successfully advanced to the next
        /// element; false if the enumerator has passed the end of the
        /// collection.
        /// </returns>
        public override Boolean MoveNext()
        {

            if (_InternalEnumerator == null)
                return false;

            if (_InternalEnumerator.MoveNext())
            {
                _CurrentElement = _IPropertyGraph.GetEdge(_InternalEnumerator.Current) as IPropertyEdge<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,    TDatastructureVertex,
                                                                                                        TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,      TDatastructureEdge,
                                                                                                        TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge, TDatastructureHyperEdge>;
                return true;
            }

            else
                return false;

        }

        #endregion


        #region ToString()

        /// <summary>
        /// A string representation of this pipe.
        /// </summary>
        public override String ToString()
        {
            return base.ToString() + "<" + _InternalEnumerator.Current + ">";
        }

        #endregion

    }

}