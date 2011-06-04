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

using de.ahzf.Pipes;
using de.ahzf.Blueprints.PropertyGraph;

#endregion

namespace de.ahzf.Balder
{

    /// <summary>
    /// The PropertyMapPipe...
    /// </summary>
    public class PropertyMapPipe<TId, TRevisionId, TValue, TDatastructure, TKey, S, T>
                    : AbstractPipe<S, IDictionary<TKey, TValue>>

        where TDatastructure : IDictionary<TKey, TValue>
        where TKey           : IEquatable<TKey>,        IComparable<TKey>,        IComparable
        where TId            : IEquatable<TId>,         IComparable<TId>,         IComparable, TValue
        where TRevisionId    : IEquatable<TRevisionId>, IComparable<TRevisionId>, IComparable, TValue
        where S              : IPropertyElement<TId, TRevisionId, TKey, TValue, TDatastructure>

    {

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

                var _IElement = _InternalEnumerator.Current;

                var _Map = new Dictionary<TKey, TValue>();

                foreach (var _Key in _IElement.Properties.PropertyKeys)
                    _Map.Add(_Key, _IElement.Properties.GetProperty(_Key));

                _CurrentElement = _Map;

                return true;

            }

            else
                return false;

        }

        #endregion

    }

}