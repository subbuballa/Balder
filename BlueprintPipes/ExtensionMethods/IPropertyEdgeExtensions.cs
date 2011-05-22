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
using System.Collections.Generic;

using de.ahzf.Blueprints.PropertyGraph;

#endregion

namespace de.ahzf.BlueprintPipes.ExtensionMethods
{

    /// <summary>
    /// Some extension methods on IPropertyEdge&lt;...&gt;
    /// </summary>
    public static class IPropertyEdgeExtensions
    {

        #region BothV(this IPropertyEdge<...>)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIdVertex"></typeparam>
        /// <typeparam name="TRevisionIdVertex"></typeparam>
        /// <typeparam name="TKeyVertex"></typeparam>
        /// <typeparam name="TValueVertex"></typeparam>
        /// <typeparam name="TIdEdge"></typeparam>
        /// <typeparam name="TRevisionIdEdge"></typeparam>
        /// <typeparam name="TEdgeLabel"></typeparam>
        /// <typeparam name="TKeyEdge"></typeparam>
        /// <typeparam name="TValueEdge"></typeparam>
        /// <typeparam name="TIdHyperEdge"></typeparam>
        /// <typeparam name="TRevisionIdHyperEdge"></typeparam>
        /// <typeparam name="THyperEdgeLabel"></typeparam>
        /// <typeparam name="TKeyHyperEdge"></typeparam>
        /// <typeparam name="TValueHyperEdge"></typeparam>
        /// <param name="IPropertyEdge"></param>
        /// <returns></returns>
        public static BothVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                       BothV<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                             this IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IPropertyEdge)

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

            return new BothVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(
                                    
                                    new List<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                           TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                           TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IPropertyEdge });

        }

        #endregion

        #region BothV(this IEnumerable<IPropertyEdge<...>>)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIdVertex"></typeparam>
        /// <typeparam name="TRevisionIdVertex"></typeparam>
        /// <typeparam name="TKeyVertex"></typeparam>
        /// <typeparam name="TValueVertex"></typeparam>
        /// <typeparam name="TIdEdge"></typeparam>
        /// <typeparam name="TRevisionIdEdge"></typeparam>
        /// <typeparam name="TEdgeLabel"></typeparam>
        /// <typeparam name="TKeyEdge"></typeparam>
        /// <typeparam name="TValueEdge"></typeparam>
        /// <typeparam name="TIdHyperEdge"></typeparam>
        /// <typeparam name="TRevisionIdHyperEdge"></typeparam>
        /// <typeparam name="THyperEdgeLabel"></typeparam>
        /// <typeparam name="TKeyHyperEdge"></typeparam>
        /// <typeparam name="TValueHyperEdge"></typeparam>
        /// <param name="IEnumerable"></param>
        /// <returns></returns>
        public static BothVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                       BothV<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                             this IEnumerable<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable)

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

            return new BothVerticesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion


        #region InV(this IPropertyEdge<...>)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIdVertex"></typeparam>
        /// <typeparam name="TRevisionIdVertex"></typeparam>
        /// <typeparam name="TKeyVertex"></typeparam>
        /// <typeparam name="TValueVertex"></typeparam>
        /// <typeparam name="TIdEdge"></typeparam>
        /// <typeparam name="TRevisionIdEdge"></typeparam>
        /// <typeparam name="TEdgeLabel"></typeparam>
        /// <typeparam name="TKeyEdge"></typeparam>
        /// <typeparam name="TValueEdge"></typeparam>
        /// <typeparam name="TIdHyperEdge"></typeparam>
        /// <typeparam name="TRevisionIdHyperEdge"></typeparam>
        /// <typeparam name="THyperEdgeLabel"></typeparam>
        /// <typeparam name="TKeyHyperEdge"></typeparam>
        /// <typeparam name="TValueHyperEdge"></typeparam>
        /// <param name="IPropertyEdge"></param>
        /// <returns></returns>
        public static InVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   InV<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                         this IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IPropertyEdge)

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

            return new InVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(
                                    
                                    new List<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                           TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                           TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IPropertyEdge });

        }

        #endregion

        #region InV(this IEnumerable<IPropertyEdge<...>>)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIdVertex"></typeparam>
        /// <typeparam name="TRevisionIdVertex"></typeparam>
        /// <typeparam name="TKeyVertex"></typeparam>
        /// <typeparam name="TValueVertex"></typeparam>
        /// <typeparam name="TIdEdge"></typeparam>
        /// <typeparam name="TRevisionIdEdge"></typeparam>
        /// <typeparam name="TEdgeLabel"></typeparam>
        /// <typeparam name="TKeyEdge"></typeparam>
        /// <typeparam name="TValueEdge"></typeparam>
        /// <typeparam name="TIdHyperEdge"></typeparam>
        /// <typeparam name="TRevisionIdHyperEdge"></typeparam>
        /// <typeparam name="THyperEdgeLabel"></typeparam>
        /// <typeparam name="TKeyHyperEdge"></typeparam>
        /// <typeparam name="TValueHyperEdge"></typeparam>
        /// <param name="IEnumerable"></param>
        /// <returns></returns>
        public static InVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   InV<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                         this IEnumerable<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable)

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

            return new InVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion


        #region OutV(this IPropertyEdge<...>)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIdVertex"></typeparam>
        /// <typeparam name="TRevisionIdVertex"></typeparam>
        /// <typeparam name="TKeyVertex"></typeparam>
        /// <typeparam name="TValueVertex"></typeparam>
        /// <typeparam name="TIdEdge"></typeparam>
        /// <typeparam name="TRevisionIdEdge"></typeparam>
        /// <typeparam name="TEdgeLabel"></typeparam>
        /// <typeparam name="TKeyEdge"></typeparam>
        /// <typeparam name="TValueEdge"></typeparam>
        /// <typeparam name="TIdHyperEdge"></typeparam>
        /// <typeparam name="TRevisionIdHyperEdge"></typeparam>
        /// <typeparam name="THyperEdgeLabel"></typeparam>
        /// <typeparam name="TKeyHyperEdge"></typeparam>
        /// <typeparam name="TValueHyperEdge"></typeparam>
        /// <param name="IPropertyEdge"></param>
        /// <returns></returns>
        public static OutVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                    OutV<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                          TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                          TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                          this IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge> IPropertyEdge)

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

            return new OutVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(
                                    
                                     new List<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                            TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                            TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>>() { IPropertyEdge });

        }

        #endregion

        #region OutV(this IEnumerable<IPropertyEdge<...>>)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIdVertex"></typeparam>
        /// <typeparam name="TRevisionIdVertex"></typeparam>
        /// <typeparam name="TKeyVertex"></typeparam>
        /// <typeparam name="TValueVertex"></typeparam>
        /// <typeparam name="TIdEdge"></typeparam>
        /// <typeparam name="TRevisionIdEdge"></typeparam>
        /// <typeparam name="TEdgeLabel"></typeparam>
        /// <typeparam name="TKeyEdge"></typeparam>
        /// <typeparam name="TValueEdge"></typeparam>
        /// <typeparam name="TIdHyperEdge"></typeparam>
        /// <typeparam name="TRevisionIdHyperEdge"></typeparam>
        /// <typeparam name="THyperEdgeLabel"></typeparam>
        /// <typeparam name="TKeyHyperEdge"></typeparam>
        /// <typeparam name="TValueHyperEdge"></typeparam>
        /// <param name="IEnumerable"></param>
        /// <returns></returns>
        public static OutVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                    OutV<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                          TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                          TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                          this IEnumerable<IPropertyEdge<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable)

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

            return new OutVertexPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

    }

}
