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

namespace de.ahzf.Pipes.ExtensionMethods
{

    /// <summary>
    /// Some extension methods on IPropertyVertex&lt;...&gt;
    /// </summary>
    public static class IPropertyVertexExtensions
    {

        #region BothE(this IEnumerable<IPropertyVertex<...>>)

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
        public static BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                    BothE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                          TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                          TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                          this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
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

            return new BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region BothE(this IEnumerable<IPropertyVertex<...>>, Label)

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
        /// <param name="Label"></param>
        /// <returns></returns>
        public static BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                    BothE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                          TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                          TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                          this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                          TEdgeLabel Label)

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

            return new BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        }

        #endregion

        #region BothE(this IEnumerator<IPropertyVertex<...>>)

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
        /// <param name="IEnumerator"></param>
        /// <returns></returns>
        public static BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                    BothE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                          TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                          TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                          this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)

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

            return new BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(null, IEnumerator);

        }

        #endregion

        #region BothE(this IEnumerator<IPropertyVertex<...>>, Label)

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
        /// <param name="IEnumerator"></param>
        /// <param name="Label"></param>
        /// <returns></returns>
        public static BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                    BothE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                          TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                          TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                          this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                           TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                           TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator,

                                          TEdgeLabel Label)

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

            return new BothEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, null, IEnumerator);

        }

        #endregion


        #region Both(this IEnumerable<IPropertyVertex<...>>)

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
        public static BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                               TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                               TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                               Both<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                    this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
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

            return new BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region Both(this IEnumerable<IPropertyVertex<...>>, Label)

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
        /// <param name="Label"></param>
        /// <returns></returns>
        public static BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                               TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                               TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                               Both<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                    this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                    TEdgeLabel Label)

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

            return new BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        }

        #endregion

        #region Both(this IEnumerator<IPropertyVertex<...>>)

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
        /// <param name="IEnumerator"></param>
        /// <returns></returns>
        public static BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                               TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                               TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                               Both<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                    this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)

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

            return new BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(null, IEnumerator);

        }

        #endregion

        #region Both(this IEnumerator<IPropertyVertex<...>>, Label)

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
        /// <param name="IEnumerator"></param>
        /// <param name="Label"></param>
        /// <returns></returns>
        public static BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                               TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                               TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                               Both<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                    this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                     TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                     TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator,

                                    TEdgeLabel Label)

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

            return new BothPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, null, IEnumerator);

        }

        #endregion


        #region InE(this IEnumerable<IPropertyVertex<...>>)

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
        public static InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                  InE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                      TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                      TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                      this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
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

            return new InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region InE(this IEnumerable<IPropertyVertex<...>>, Label)

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
        /// <param name="Label"></param>
        /// <returns></returns>
        public static InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                  InE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                      TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                      TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                      this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                      TEdgeLabel Label)

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

            return new InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        }

        #endregion

        #region InE(this IEnumerator<IPropertyVertex<...>>)

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
        /// <param name="IEnumerator"></param>
        /// <returns></returns>
        public static InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                  InE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                      TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                      TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                      this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)

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

            return new InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(null, IEnumerator);

        }

        #endregion

        #region InE(this IEnumerator<IPropertyVertex<...>>, Label)

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
        /// <param name="IEnumerator"></param>
        /// <param name="Label"></param>
        /// <returns></returns>
        public static InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                  InE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                      TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                      TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                      this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                       TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                       TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator,

                                      TEdgeLabel Label)

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

            return new InEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, null, IEnumerator);

        }

        #endregion


        #region In(this IEnumerable<IPropertyVertex<...>>)

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
        public static InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                             In<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
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

            return new InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region In(this IEnumerable<IPropertyVertex<...>>, Label)

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
        /// <param name="Label"></param>
        /// <returns></returns>
        public static InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                             In<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                 TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                 TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                TEdgeLabel Label)

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

            return new InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        }

        #endregion

        #region In(this IEnumerator<IPropertyVertex<...>>)

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
        /// <param name="IEnumerator"></param>
        /// <returns></returns>
        public static InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                             In<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                 TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                 TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)

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

            return new InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(null, IEnumerator);

        }

        #endregion

        #region In(this IEnumerator<IPropertyVertex<...>>, Label)

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
        /// <param name="IEnumerator"></param>
        /// <param name="Label"></param>
        /// <returns></returns>
        public static InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                             TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                             TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                             In<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                 TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                 TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator,

                                TEdgeLabel Label)

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

            return new InPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, null, IEnumerator);

        }

        #endregion


        #region OutE(this IEnumerable<IPropertyVertex<...>>)

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
        public static OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   OutE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                        this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
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

            return new OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region OutE(this IEnumerable<IPropertyVertex<...>>, Label)

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
        /// <param name="Label"></param>
        /// <returns></returns>
        public static OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   OutE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                        this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                        TEdgeLabel Label)

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

            return new OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        }

        #endregion

        #region OutE(this IEnumerator<IPropertyVertex<...>>)

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
        /// <param name="IEnumerator"></param>
        /// <returns></returns>
        public static OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   OutE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                        this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)

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

            return new OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(null, IEnumerator);

        }

        #endregion

        #region OutE(this IEnumerator<IPropertyVertex<...>>, Label)

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
        /// <param name="IEnumerator"></param>
        /// <param name="Label"></param>
        /// <returns></returns>
        public static OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                                   OutE<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                        TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                        TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                        this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                         TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                         TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator,

                                        TEdgeLabel Label)

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

            return new OutEdgesPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                    TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                    TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, null, IEnumerator);

        }

        #endregion


        #region Out(this IEnumerable<IPropertyVertex<...>>)

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
        public static OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                              Out<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                 TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                 TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                 this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
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

            return new OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                               TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                               TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(IEnumerable);

        }

        #endregion

        #region Out(this IEnumerable<IPropertyVertex<...>>, Label)

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
        /// <param name="Label"></param>
        /// <returns></returns>
        public static OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                              Out<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                  this IEnumerable<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerable,

                                  TEdgeLabel Label)

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

            return new OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, IEnumerable);

        }

        #endregion

        #region Out(this IEnumerator<IPropertyVertex<...>>)

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
        /// <param name="IEnumerator"></param>
        /// <returns></returns>
        public static OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                              Out<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                  this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator)

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

            return new OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(null, IEnumerator);

        }

        #endregion

        #region Out(this IEnumerator<IPropertyVertex<...>>, Label)

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
        /// <param name="IEnumerator"></param>
        /// <param name="Label"></param>
        /// <returns></returns>
        public static OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>

                              Out<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                  TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                  TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(

                                  this IEnumerator<IPropertyVertex<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                                                                   TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                                                                   TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>> IEnumerator,

                                  TEdgeLabel Label)

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

            return new OutPipe<TIdVertex,    TRevisionIdVertex,                     TKeyVertex,    TValueVertex,
                              TIdEdge,      TRevisionIdEdge,      TEdgeLabel,      TKeyEdge,      TValueEdge,
                              TIdHyperEdge, TRevisionIdHyperEdge, THyperEdgeLabel, TKeyHyperEdge, TValueHyperEdge>(Label, null, IEnumerator);

        }

        #endregion

    }

}
