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

using de.ahzf.blueprints.PropertyGraph;

#endregion

namespace de.ahzf.Pipes
{

    /// <summary>
    /// The LabelFilterPipe either allows or disallows all
    /// Edges that have the provided label.
    /// </summary>
    public class LabelFilterPipe<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,
                                 TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,
                                 TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge> : AbstractComparisonFilterPipe<IPropertyEdge<TIdVertex,    TRevisionIdVertex,    TKeyVertex,    TValueVertex,
                                                                                                                                                  TIdEdge,      TRevisionIdEdge,      TKeyEdge,      TValueEdge,
                                                                                                                                                  TIdHyperEdge, TRevisionIdHyperEdge, TKeyHyperEdge, TValueHyperEdge>, String>

        where TKeyVertex              : IEquatable<TKeyVertex>,           IComparable<TKeyVertex>,           IComparable
        where TKeyEdge                : IEquatable<TKeyEdge>,             IComparable<TKeyEdge>,             IComparable
        where TKeyHyperEdge           : IEquatable<TKeyHyperEdge>,        IComparable<TKeyHyperEdge>,        IComparable

        where TIdVertex               : IEquatable<TIdVertex>,            IComparable<TIdVertex>,            IComparable, TValueVertex
        where TIdEdge                 : IEquatable<TIdEdge>,              IComparable<TIdEdge>,              IComparable, TValueEdge
        where TIdHyperEdge            : IEquatable<TIdHyperEdge>,         IComparable<TIdHyperEdge>,         IComparable, TValueHyperEdge

        where TRevisionIdVertex       : IEquatable<TRevisionIdVertex>,    IComparable<TRevisionIdVertex>,    IComparable, TValueVertex
        where TRevisionIdEdge         : IEquatable<TRevisionIdEdge>,      IComparable<TRevisionIdEdge>,      IComparable, TValueEdge
        where TRevisionIdHyperEdge    : IEquatable<TRevisionIdHyperEdge>, IComparable<TRevisionIdHyperEdge>, IComparable, TValueHyperEdge

    {

        #region Data

        private readonly String _Label;

        #endregion

        #region Constructor(s)

        #region LabelFilterPipe(myLabel, myComparisonFilter)

        /// <summary>
        /// Creates a new LabelFilterPipe.
        /// </summary>
        /// <param name="myLabel">The edge label.</param>
        /// <param name="myComparisonFilter">The filter to use.</param>
        public LabelFilterPipe(String myLabel, ComparisonFilter myComparisonFilter)
            : base(myComparisonFilter)
        {
            _Label = myLabel;
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

                if (_InternalEnumerator.MoveNext())
                {

                    var _Edge = _InternalEnumerator.Current;

                    if (!CompareObjects(_Edge.Label, _Label))
                    {
                        _CurrentElement = _Edge;
                        return true;
                    }

                }

                else
                    return false;

            }

        }

        #endregion


        #region ToString()

        /// <summary>
        /// A string representation of this pipe.
        /// </summary>
        public override String ToString()
        {
            return base.ToString() + "<" + _Filter + "," + _Label + ">";
        }

        #endregion

    }

}