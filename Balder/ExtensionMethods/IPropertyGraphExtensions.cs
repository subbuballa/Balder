﻿/*
 * Copyright (c) 2010-2011, Achim 'ahzf' Friedland <code@ahzf.de>
 * This file is part of Balder.NET <http://www.github.com/ahzf/Balder.NET>
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

using de.ahzf.Blueprints.PropertyGraph;

#endregion

namespace de.ahzf.Balder.ExtensionMethods
{

    /// <summary>
    /// Extension methods for pipes consuming PropertyGraphs.
    /// </summary>
    public static class IPropertyGraphExtensions
    {

        #region V(this IPropertyGraph<...>, VertexFilter = null)

        /// <summary>
        /// Returns all vertices of a the given PropertyGraph.
        /// </summary>
        /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        /// <typeparam name="TRevisionIdVertex">The type of the vertex revision identifiers.</typeparam>
        /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        /// 
        /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdEdge">The type of the edge revision identifiers.</typeparam>
        /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        /// 
        /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        /// <param name="IPropertyGraph">A PropertyGraph.</param>
        /// <param name="VertexFilter">An optional delegate for vertex filtering.</param>
        /// <returns>All vertices of a the given PropertyGraph.</returns>
        public static AllVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                      TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                      TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                      V<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                        this IPropertyGraph<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IPropertyGraph,

                                        VertexFilter<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> VertexFilter = null)

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

            return new AllVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(
                                       
                                       VertexFilter,
                                       new List<IPropertyGraph<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                               TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                               TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IPropertyGraph });

        }

        #endregion

        #region V(this IEnumerable<IPropertyGraph<...>>, VertexFilter = null)

        /// <summary>
        /// Returns all vertices of a the given PropertyGraphs.
        /// </summary>
        /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        /// <typeparam name="TRevisionIdVertex">The type of the vertex revision identifiers.</typeparam>
        /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        /// 
        /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdEdge">The type of the edge revision identifiers.</typeparam>
        /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        /// 
        /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        /// <param name="IEnumerable">An enumeration of PropertyGraphs.</param>
        /// <param name="VertexFilter">An optional delegate for vertex filtering.</param>
        /// <returns>All vertices of a the given PropertyGraphs.</returns>
        public static AllVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                      TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                      TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                      V<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                        this IEnumerable<IPropertyGraph<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                        VertexFilter<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> VertexFilter = null)

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

            return new AllVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(VertexFilter, IEnumerable);

        }

        #endregion


        #region E(this IPropertyGraph<...>, EdgeFilter = null)

        /// <summary>
        /// Returns all edges of a the given PropertyGraph.
        /// </summary>
        /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        /// <typeparam name="TRevisionIdVertex">The type of the vertex revision identifiers.</typeparam>
        /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        /// 
        /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdEdge">The type of the edge revision identifiers.</typeparam>
        /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        /// 
        /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        /// <param name="IPropertyGraph">A PropertyGraph.</param>
        /// <param name="EdgeFilter">An optional delegate for vertex filtering.</param>
        /// <returns>All edges of a the given PropertyGraph.</returns>
        public static AllEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   E<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                     this IPropertyGraph<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IPropertyGraph,

                                     EdgeFilter<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> EdgeFilter = null)

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

            return new AllEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(
                                    
                                    EdgeFilter,
                                    new List<IPropertyGraph<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IPropertyGraph });

        }

        #endregion

        #region E(this IEnumerable<IPropertyGraph<...>>, EdgeFilter = null)

        /// <summary>
        /// Returns all vertices of a the given PropertyGraphs.
        /// </summary>
        /// <typeparam name="TIdVertex">The type of the vertex identifiers.</typeparam>
        /// <typeparam name="TRevisionIdVertex">The type of the vertex revision identifiers.</typeparam>
        /// <typeparam name="TKeyVertex">The type of the vertex property keys.</typeparam>
        /// <typeparam name="TValueVertex">The type of the vertex property values.</typeparam>
        /// 
        /// <typeparam name="TIdEdge">The type of the edge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdEdge">The type of the edge revision identifiers.</typeparam>
        /// <typeparam name="TEdgeLabel">The type of the edge label.</typeparam>
        /// <typeparam name="TKeyEdge">The type of the edge property keys.</typeparam>
        /// <typeparam name="TValueEdge">The type of the edge property values.</typeparam>
        /// 
        /// <typeparam name="TIdHyperEdge">The type of the hyperedge identifiers.</typeparam>
        /// <typeparam name="TRevisionIdHyperEdge">The type of the hyperedge revision identifiers.</typeparam>
        /// <typeparam name="THyperEdgeLabel">The type of the hyperedge label.</typeparam>
        /// <typeparam name="TKeyHyperEdge">The type of the hyperedge property keys.</typeparam>
        /// <typeparam name="TValueHyperEdge">The type of the hyperedge property values.</typeparam>
        /// <param name="IEnumerable">An enumeration of PropertyGraphs.</param>
        /// <param name="EdgeFilter">An optional delegate for vertex filtering.</param>
        /// <returns>All vertices of a the given PropertyGraphs.</returns>
        public static AllEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   E<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                     this IEnumerable<IPropertyGraph<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                     EdgeFilter<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> EdgeFilter = null)

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

            return new AllEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(EdgeFilter, IEnumerable);

        }

        #endregion

    }

}
