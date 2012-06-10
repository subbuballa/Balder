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
using de.ahzf.Vanaheimr.Styx;

#endregion

namespace de.ahzf.Vanaheimr.Balder
{

    /// <summary>
    /// Extension methods for the HyperEdgeVerticesPipe.
    /// </summary>
    public static class HyperEdgeVerticesPipeExtensions
    {

        #region V(this IGenericPropertyHyperEdge<...>)

        /// <summary>
        /// Returns the outgoing vertices of the given hyperedge.
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
        /// <param name="IGenericPropertyHyperEdge">A hyperedge.</param>
        /// <returns>The outgoing vertices of the given hyperedge.</returns>
        public static HyperEdgeVerticesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                            V<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                              this IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                             TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                             TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                             TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IGenericPropertyHyperEdge)

            where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
            where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
            where TKeyMultiEdge           : IEquatable<TKeyMultiEdge>,        IComparable<TKeyMultiEdge>,        IComparable
            where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

            where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
            where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
            where TIdMultiEdge            : IEquatable<TIdMultiEdge>,         IComparable<TIdMultiEdge>,         IComparable, TValueMultiEdge
            where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

            where TVertexLabel            : IEquatable<TVertexLabel>,         IComparable<TVertexLabel>,         IComparable
            where TEdgeLabel              : IEquatable<TEdgeLabel>,           IComparable<TEdgeLabel>,           IComparable
            where TMultiEdgeLabel         : IEquatable<TMultiEdgeLabel>,      IComparable<TMultiEdgeLabel>,      IComparable
            where THyperEdgeLabel         : IEquatable<THyperEdgeLabel>,      IComparable<THyperEdgeLabel>,      IComparable

            where TRevIdVertex       : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
            where TRevIdEdge         : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
            where TRevIdMultiEdge    : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
            where TRevIdHyperEdge    : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

        {

            return new HyperEdgeVerticesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                             TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                             TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                             TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                             new List<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                                TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                                TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                                TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IGenericPropertyHyperEdge });

        }

        #endregion

        #region V(this IEnumerable<IGenericPropertyHyperEdge<...>>)

        /// <summary>
        /// Returns the outgoing vertices of the given hyperedge.
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
        /// <param name="IEnumerable">An enumeration of hyperedges.</param>
        /// <returns>The outgoing vertices of the given hyperedges.</returns>
        public static HyperEdgeVerticesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                            TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                            TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                            TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                            V<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                              this IEnumerable<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                                         TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                                         TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                                         TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable)

            where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
            where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
            where TKeyMultiEdge           : IEquatable<TKeyMultiEdge>,        IComparable<TKeyMultiEdge>,        IComparable
            where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

            where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
            where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
            where TIdMultiEdge            : IEquatable<TIdMultiEdge>,         IComparable<TIdMultiEdge>,         IComparable, TValueMultiEdge
            where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

            where TVertexLabel            : IEquatable<TVertexLabel>,         IComparable<TVertexLabel>,         IComparable
            where TEdgeLabel              : IEquatable<TEdgeLabel>,           IComparable<TEdgeLabel>,           IComparable
            where TMultiEdgeLabel         : IEquatable<TMultiEdgeLabel>,      IComparable<TMultiEdgeLabel>,      IComparable
            where THyperEdgeLabel         : IEquatable<THyperEdgeLabel>,      IComparable<THyperEdgeLabel>,      IComparable

            where TRevIdVertex       : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
            where TRevIdEdge         : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
            where TRevIdMultiEdge    : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
            where TRevIdHyperEdge    : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

        {

            return new HyperEdgeVerticesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                             TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                             TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                             TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region OutHE(this IPropertyVertex<...>, Label)

        /// <summary>
        /// Returns the outgoing hyperedges of the given PropertyVertex
        /// having the given hyperedgelabel.
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
        /// <param name="IPropertyVertex">A PropertyVertex.</param>
        /// <param name="Label">The label of the outgoing hyperedges.</param>
        /// <returns>The outgoing hyperedges of the given PropertyVertex having the given hyper edge label.</returns>
        public static OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                        TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                        OutHE<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                              this IGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                          TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                          TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                          TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IPropertyVertex,
                                              THyperEdgeLabel Label)

            where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
            where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
            where TKeyMultiEdge           : IEquatable<TKeyMultiEdge>,        IComparable<TKeyMultiEdge>,        IComparable
            where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

            where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
            where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
            where TIdMultiEdge            : IEquatable<TIdMultiEdge>,         IComparable<TIdMultiEdge>,         IComparable, TValueMultiEdge
            where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

            where TVertexLabel            : IEquatable<TVertexLabel>,         IComparable<TVertexLabel>,         IComparable
            where TEdgeLabel              : IEquatable<TEdgeLabel>,           IComparable<TEdgeLabel>,           IComparable
            where TMultiEdgeLabel         : IEquatable<TMultiEdgeLabel>,      IComparable<TMultiEdgeLabel>,      IComparable
            where THyperEdgeLabel         : IEquatable<THyperEdgeLabel>,      IComparable<THyperEdgeLabel>,      IComparable

            where TRevIdVertex       : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
            where TRevIdEdge         : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
            where TRevIdMultiEdge    : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
            where TRevIdHyperEdge    : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

        {

            return new OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                         TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                         TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                         TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(
                                     
                                         Label,
                                         new List<IGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                         TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                         TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                         TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IPropertyVertex });

        }

        #endregion

        //#region OutHE(this IEnumerable<IPropertyVertex<...>>, Label)

        ///// <summary>
        ///// Returns the outgoing hyperedges of the given PropertyVertices
        ///// having the given hyperedgelabel.
        ///// </summary>
        ///// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        ///// <typeparam name="TRevIdVertex">The type of the vertex revision identifiers.</typeparam>
        ///// <typeparam name="TVertexLabel">The type of the vertex type.</typeparam>
        ///// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        ///// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        ///// 
        ///// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        ///// <typeparam name="TRevIdEdge">The type of the edge revision identifiers.</typeparam>
        ///// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        ///// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        ///// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        ///// 
        ///// <typeparam name="TIdMultiEdge">The type of the multiedge identifiers.</typeparam>
        ///// <typeparam name="TRevIdMultiEdge">The type of the multiedge revision identifiers.</typeparam>
        ///// <typeparam name="TMultiEdgeLabel">The type of the multiedge label.</typeparam>
        ///// <typeparam name="TKeyMultiEdge">The type of the multiedge property keys.</typeparam>
        ///// <typeparam name="TValueMultiEdge">The type of the multiedge property values.</typeparam>
        ///// 
        ///// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        ///// <typeparam name="TRevIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        ///// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        ///// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        ///// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        ///// <param name="IEnumerable">An enumeration of PropertyVertices.</param>
        ///// <param name="Label">The label of the outgoing hyperedges.</param>
        ///// <returns>The outgoing hyperedges of the given PropertyVertices having the given edge label.</returns>
        //public static OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
        //                                TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
        //                                TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
        //                                TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

        //                                OutHE<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
        //                                      TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
        //                                      TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
        //                                      TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

        //                                      this IEnumerable<IGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
        //                                                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
        //                                                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
        //                                                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,
        //                                      THyperEdgeLabel Label)

        //    where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
        //    where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
        //    where TKeyMultiEdge           : IEquatable<TKeyMultiEdge>,        IComparable<TKeyMultiEdge>,        IComparable
        //    where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

        //    where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
        //    where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
        //    where TIdMultiEdge            : IEquatable<TIdMultiEdge>,         IComparable<TIdMultiEdge>,         IComparable, TValueMultiEdge
        //    where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

        //    where TVertexLabel            : IEquatable<TVertexLabel>,         IComparable<TVertexLabel>,         IComparable
        //    where TEdgeLabel              : IEquatable<TEdgeLabel>,           IComparable<TEdgeLabel>,           IComparable
        //    where TMultiEdgeLabel         : IEquatable<TMultiEdgeLabel>,      IComparable<TMultiEdgeLabel>,      IComparable
        //    where THyperEdgeLabel         : IEquatable<THyperEdgeLabel>,      IComparable<THyperEdgeLabel>,      IComparable

        //    where TRevIdVertex       : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
        //    where TRevIdEdge         : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
        //    where TRevIdMultiEdge    : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
        //    where TRevIdHyperEdge    : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

        //{

        //    return new OutHyperEdgesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
        //                                 TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
        //                                 TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
        //                                 TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        //}

        //#endregion

    }

    #region HyperEdgeVerticesPipe()

    /// <summary>
    /// The HyperEdgeVerticesPipe emits all vertices of a hyperedge.
    /// </summary>
    public class HyperEdgeVerticesPipe<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                       TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                       TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                       TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                     : AbstractPipe<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                              TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                              TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                              TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>,
                   
                                    IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                   TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                   TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                   TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>


        where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
        where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
        where TKeyMultiEdge           : IEquatable<TKeyMultiEdge>,        IComparable<TKeyMultiEdge>,        IComparable
        where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

        where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
        where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
        where TIdMultiEdge            : IEquatable<TIdMultiEdge>,         IComparable<TIdMultiEdge>,         IComparable, TValueMultiEdge
        where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

        where TVertexLabel            : IEquatable<TVertexLabel>,         IComparable<TVertexLabel>,         IComparable
        where TEdgeLabel              : IEquatable<TEdgeLabel>,           IComparable<TEdgeLabel>,           IComparable
        where TMultiEdgeLabel         : IEquatable<TMultiEdgeLabel>,      IComparable<TMultiEdgeLabel>,      IComparable
        where THyperEdgeLabel         : IEquatable<THyperEdgeLabel>,      IComparable<THyperEdgeLabel>,      IComparable

        where TRevIdVertex       : IEquatable<TRevIdVertex>,    IComparable<TRevIdVertex>,    IComparable, TValueVertex
        where TRevIdEdge         : IEquatable<TRevIdEdge>,      IComparable<TRevIdEdge>,      IComparable, TValueEdge
        where TRevIdMultiEdge    : IEquatable<TRevIdMultiEdge>, IComparable<TRevIdMultiEdge>, IComparable, TValueMultiEdge
        where TRevIdHyperEdge    : IEquatable<TRevIdHyperEdge>, IComparable<TRevIdHyperEdge>, IComparable, TValueHyperEdge

    {

        #region Data

        /// <summary>
        /// The label of the vertices to visit.
        /// </summary>
        private TVertexLabel _VertexLabel;

        /// <summary>
        /// If the vertex label is in use, as _Label is always at least default(TVertexLabel)!
        /// </summary>
        private Boolean _UseVertexLabel;
        
        /// <summary>
        /// Vertices to be traversed next...
        /// </summary>
        private IEnumerator<IReadOnlyGenericPropertyVertex<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                           TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                           TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                           TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> _NextVertices;

        #endregion

        #region Constructor(s)

        #region HyperEdgeVerticesPipe(IEnumerable = null, IEnumerator = null)

        /// <summary>
        /// Creates a new HyperEdgeVerticesPipe emitting all vertices of a hyperedge.
        /// </summary>
        /// <param name="IEnumerable">An optional IEnumerable&lt;...&gt; as element source.</param>
        /// <param name="IEnumerator">An optional IEnumerator&lt;...&gt; as element source.</param>
        public HyperEdgeVerticesPipe(IEnumerable<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                           TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable = null,

                                     IEnumerator<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                           TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator = null)

            : base(IEnumerable, IEnumerator)

        { }

        #endregion

        #region HyperEdgeVerticesPipe(VertexLabel, IEnumerable = null, IEnumerator = null)

        /// <summary>
        /// Creates a new HyperEdgeVerticesPipe emitting all vertices of a hyperedge.
        /// </summary>
        /// <param name="VertexLabel">The vertex label.</param>
        /// <param name="IEnumerable">An optional IEnumerable&lt;...&gt; as element source.</param>
        /// <param name="IEnumerator">An optional IEnumerator&lt;...&gt; as element source.</param>
        public HyperEdgeVerticesPipe(TVertexLabel VertexLabel,            
                                     IEnumerable<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                           TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable = null,

                                     IEnumerator<IGenericPropertyHyperEdge<TIdVertex,    TRevIdVertex,    TVertexLabel,    TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdMultiEdge, TRevIdMultiEdge, TMultiEdgeLabel, TKeyMultiEdge, TValueMultiEdge,
                                                                           TIdHyperEdge, TRevIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator = null)

            : base(IEnumerable, IEnumerator)

        {
            this._VertexLabel = VertexLabel;
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

            while (true)
            {

                if (_NextVertices != null && _NextVertices.MoveNext())
                {
                    _CurrentElement = _NextVertices.Current;
                    return true;
                }

                else if (_InternalEnumerator.MoveNext())
                {

                    if (_UseVertexLabel)
                        _NextVertices = _InternalEnumerator.Current.VerticesByLabel(_VertexLabel).GetEnumerator();
                    else
                        _NextVertices = _InternalEnumerator.Current.Vertices().GetEnumerator();

                }

                else
                    return false;

            }

        }

        #endregion

    }

    #endregion

}
