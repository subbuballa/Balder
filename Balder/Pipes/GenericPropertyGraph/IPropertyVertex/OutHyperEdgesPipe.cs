/*
 * Copyright (c) 2010-2012, Achim 'ahzf' Friedland <achim@graph-database.org>
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

using de.ahzf.Vanaheimr.Blueprints;

#endregion

namespace de.ahzf.Vanaheimr.Balder
{

    #region OutHyperEdgesPipeExtensions

    /// <summary>
    /// Extension methods for the OutHyperEdgesPipe.
    /// </summary>
    public static class OutHyperEdgesPipeExtensions
    {

        #region OutHE(this IEnumerable<IReadOnlyGenericPropertyVertex<...>>)

        /// <summary>
        /// Emit the outgoing hyperedges of the given generic property vertices.
        /// </summary>
        /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        /// <typeparam name="TRevIdVertex">The type of the vertex revision identifiers.</typeparam>
        /// <typeparam name="TVertexLabel">The type of the vertex type.</typeparam>
        /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        /// 
        /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        /// <typeparam name="TRevIdEdge">The type of the edge revision identifiers.</typeparam>
        /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        /// 
        /// <typeparam name="TIdMultiEdge">The type of the multiedge identifiers.</typeparam>
        /// <typeparam name="TRevIdMultiEdge">The type of the multiedge revision identifiers.</typeparam>
        /// <typeparam name="TMultiEdgeLabel">The type of the multiedge label.</typeparam>
        /// <typeparam name="TKeyMultiEdge">The type of the multiedge property keys.</typeparam>
        /// <typeparam name="TValueMultiEdge">The type of the multiedge property values.</typeparam>
        /// 
        /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        /// <typeparam name="TRevIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        /// <param name="IEnumerable">An enumeration of generic property vertices.</param>
        /// <returns>The outgoing hyperedges of the given generic property vertices.</returns>
        public static OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                        TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                        OutHE<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                            this IEnumerable<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable)


            where TIdVertex        : IEquatable<TIdVertex>,       IComparable<TIdVertex>,       IComparable, TValueVertex
            where TIdEdge          : IEquatable<TIdEdge>,         IComparable<TIdEdge>,         IComparable, TValueEdge
            where TIdMultiEdge     : IEquatable<TIdMultiEdge>,    IComparable<TIdMultiEdge>,    IComparable, TValueMultiEdge
            where TIdHyperEdge     : IEquatable<TIdHyperEdge>,    IComparable<TIdHyperEdge>,    IComparable, TValueHyperEdge

            where TRevIdVertex     : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
            where TRevIdEdge       : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
            where TRevIdMultiEdge  : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
            where TRevIdHyperEdge  : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

            where TVertexLabel     : IEquatable<TVertexLabel>,    IComparable<TVertexLabel>,    IComparable
            where TEdgeLabel       : IEquatable<TEdgeLabel>,      IComparable<TEdgeLabel>,      IComparable
            where TMultiEdgeLabel  : IEquatable<TMultiEdgeLabel>, IComparable<TMultiEdgeLabel>, IComparable
            where THyperEdgeLabel  : IEquatable<THyperEdgeLabel>, IComparable<THyperEdgeLabel>, IComparable

            where TKeyVertex       : IEquatable<TKeyVertex>,      IComparable<TKeyVertex>,      IComparable
            where TKeyEdge         : IEquatable<TKeyEdge>,        IComparable<TKeyEdge>,        IComparable
            where TKeyMultiEdge    : IEquatable<TKeyMultiEdge>,   IComparable<TKeyMultiEdge>,   IComparable
            where TKeyHyperEdge    : IEquatable<TKeyHyperEdge>,   IComparable<TKeyHyperEdge>,   IComparable

        {

            return new OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                         TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                         TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                         TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region OutHE(this IEnumerable<IReadOnlyGenericPropertyVertex<...>>, HyperEdgeLabel)

        /// <summary>
        /// Emit the outgoing hyperedges of the given generic property vertices
        /// having the given HyperEdgeLabel.
        /// </summary>
        /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        /// <typeparam name="TRevIdVertex">The type of the vertex revision identifiers.</typeparam>
        /// <typeparam name="TVertexLabel">The type of the vertex type.</typeparam>
        /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        /// 
        /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        /// <typeparam name="TRevIdEdge">The type of the edge revision identifiers.</typeparam>
        /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        /// 
        /// <typeparam name="TIdMultiEdge">The type of the multiedge identifiers.</typeparam>
        /// <typeparam name="TRevIdMultiEdge">The type of the multiedge revision identifiers.</typeparam>
        /// <typeparam name="TMultiEdgeLabel">The type of the multiedge label.</typeparam>
        /// <typeparam name="TKeyMultiEdge">The type of the multiedge property keys.</typeparam>
        /// <typeparam name="TValueMultiEdge">The type of the multiedge property values.</typeparam>
        /// 
        /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        /// <typeparam name="TRevIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        /// <param name="IEnumerable">An enumeration of generic property vertices.</param>
        /// <param name="HyperEdgeLabel">The label of the outgoing hyperedges.</param>
        /// <returns>The outgoing hyperedges of the given generic property vertices having the given hyperedge label.</returns>
        public static OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                        TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                        OutHE<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                              this IEnumerable<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,
                                              THyperEdgeLabel HyperEdgeLabel)


            where TIdVertex        : IEquatable<TIdVertex>,       IComparable<TIdVertex>,       IComparable, TValueVertex
            where TIdEdge          : IEquatable<TIdEdge>,         IComparable<TIdEdge>,         IComparable, TValueEdge
            where TIdMultiEdge     : IEquatable<TIdMultiEdge>,    IComparable<TIdMultiEdge>,    IComparable, TValueMultiEdge
            where TIdHyperEdge     : IEquatable<TIdHyperEdge>,    IComparable<TIdHyperEdge>,    IComparable, TValueHyperEdge

            where TRevIdVertex     : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
            where TRevIdEdge       : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
            where TRevIdMultiEdge  : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
            where TRevIdHyperEdge  : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

            where TVertexLabel     : IEquatable<TVertexLabel>,    IComparable<TVertexLabel>,    IComparable
            where TEdgeLabel       : IEquatable<TEdgeLabel>,      IComparable<TEdgeLabel>,      IComparable
            where TMultiEdgeLabel  : IEquatable<TMultiEdgeLabel>, IComparable<TMultiEdgeLabel>, IComparable
            where THyperEdgeLabel  : IEquatable<THyperEdgeLabel>, IComparable<THyperEdgeLabel>, IComparable

            where TKeyVertex       : IEquatable<TKeyVertex>,      IComparable<TKeyVertex>,      IComparable
            where TKeyEdge         : IEquatable<TKeyEdge>,        IComparable<TKeyEdge>,        IComparable
            where TKeyMultiEdge    : IEquatable<TKeyMultiEdge>,   IComparable<TKeyMultiEdge>,   IComparable
            where TKeyHyperEdge    : IEquatable<TKeyHyperEdge>,   IComparable<TKeyHyperEdge>,   IComparable

        {

            return new OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                         TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                         TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                         TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(HyperEdgeLabel, IEnumerable);

        }

        #endregion

    }

    #endregion

    #region OutHyperEdgesPipe()

    /// <summary>
    /// Emit the outgoing hyperedges of the given generic property vertices.
    /// </summary>
    /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
    /// <typeparam name="TRevIdVertex">The type of the vertex revision identifiers.</typeparam>
    /// <typeparam name="TVertexLabel">The type of the vertex type.</typeparam>
    /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
    /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
    /// 
    /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
    /// <typeparam name="TRevIdEdge">The type of the edge revision identifiers.</typeparam>
    /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
    /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
    /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
    /// 
    /// <typeparam name="TIdMultiEdge">The type of the multiedge identifiers.</typeparam>
    /// <typeparam name="TRevIdMultiEdge">The type of the multiedge revision identifiers.</typeparam>
    /// <typeparam name="TMultiEdgeLabel">The type of the multiedge label.</typeparam>
    /// <typeparam name="TKeyMultiEdge">The type of the multiedge property keys.</typeparam>
    /// <typeparam name="TValueMultiEdge">The type of the multiedge property values.</typeparam>
    /// 
    /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
    /// <typeparam name="TRevIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
    /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
    /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
    /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
    public class OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                   TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   : AbstractHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>


        where TIdVertex        : IEquatable<TIdVertex>,       IComparable<TIdVertex>,       IComparable, TValueVertex
        where TIdEdge          : IEquatable<TIdEdge>,         IComparable<TIdEdge>,         IComparable, TValueEdge
        where TIdMultiEdge     : IEquatable<TIdMultiEdge>,    IComparable<TIdMultiEdge>,    IComparable, TValueMultiEdge
        where TIdHyperEdge     : IEquatable<TIdHyperEdge>,    IComparable<TIdHyperEdge>,    IComparable, TValueHyperEdge

        where TRevIdVertex     : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
        where TRevIdEdge       : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
        where TRevIdMultiEdge  : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
        where TRevIdHyperEdge  : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

        where TVertexLabel     : IEquatable<TVertexLabel>,    IComparable<TVertexLabel>,    IComparable
        where TEdgeLabel       : IEquatable<TEdgeLabel>,      IComparable<TEdgeLabel>,      IComparable
        where TMultiEdgeLabel  : IEquatable<TMultiEdgeLabel>, IComparable<TMultiEdgeLabel>, IComparable
        where THyperEdgeLabel  : IEquatable<THyperEdgeLabel>, IComparable<THyperEdgeLabel>, IComparable

        where TKeyVertex       : IEquatable<TKeyVertex>,      IComparable<TKeyVertex>,      IComparable
        where TKeyEdge         : IEquatable<TKeyEdge>,        IComparable<TKeyEdge>,        IComparable
        where TKeyMultiEdge    : IEquatable<TKeyMultiEdge>,   IComparable<TKeyMultiEdge>,   IComparable
        where TKeyHyperEdge    : IEquatable<TKeyHyperEdge>,   IComparable<TKeyHyperEdge>,   IComparable

    {

        #region Constructor(s)

        #region OutHyperEdgesPipe(IEnumerable = null, IEnumerator = null)

        /// <summary>
        /// Emit the outgoing hyperedges of the given generic property vertices.
        /// </summary>
        /// <param name="IEnumerable">An optional IEnumerable&lt;...&gt; as element source.</param>
        /// <param name="IEnumerator">An optional IEnumerator&lt;...&gt; as element source.</param>
        public OutHyperEdgesPipe(IEnumerable<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable = null,

                                 IEnumerator<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator = null)

            : base(IEnumerable, IEnumerator)

        { }

        #endregion

        #region OutHyperEdgesPipe(HyperEdgeLabel, IEnumerable = null, IEnumerator = null)

        /// <summary>
        /// Emit the outgoing hyperedges of the given generic property vertices
        /// having the given HyperEdgeLabel.
        /// </summary>
        /// <param name="HyperEdgeLabel">The HyperEdgeLabel to traverse.</param>
        /// <param name="IEnumerable">An optional IEnumerable&lt;...&gt; as element source.</param>
        /// <param name="IEnumerator">An optional IEnumerator&lt;...&gt; as element source.</param>
        public OutHyperEdgesPipe(THyperEdgeLabel HyperEdgeLabel,
                                 IEnumerable<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable = null,

                                 IEnumerator<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator = null)

            : base(HyperEdgeLabel, IEnumerable, IEnumerator)

        { }

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

            while (true)
            {

                if (_NextHyperEdges != null && _NextHyperEdges.MoveNext())
                {
                    _CurrentElement = _NextHyperEdges.Current;
                    return true;
                }

                else if (_InternalEnumerator.MoveNext())
                {

                    if (_UseLabel)
                        _NextHyperEdges = _InternalEnumerator.Current.HyperEdges(_Label).GetEnumerator();
                    else
                        _NextHyperEdges = _InternalEnumerator.Current.HyperEdges().GetEnumerator();

                }

                else
                    return false;

            }

        }

        #endregion

    }

    #endregion

}
