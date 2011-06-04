/*
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
    /// PropertyPipeExtensions.
    /// </summary>
    public static class PropertyExtensions
    {

        #region PropertyPipe<S, E>(this myIEnumerable, myKeys)

        /// <summary>
        /// The PropertyPipe returns the property value of the
        /// Element identified by the provided key.
        /// </summary>
        /// <typeparam name="S">The type of the consuming objects.</typeparam>
        /// <typeparam name="E">The type of the emitting objects.</typeparam>
        /// <param name="myIEnumerable">A collection of consumable objects.</param>
        /// <param name="myKeys">The property keys.</param>
        /// <returns>A collection of emittable objects.</returns>
        public static IEnumerable<E> PropertyPipe<TId, TRevisionId, TKey, TValue, TDatastructure, S, E>(this IEnumerable<S> myIEnumerable, TKey[] myKeys)
            
            where TId            : IEquatable<TId>,         IComparable<TId>,         IComparable, TValue
            where TRevisionId    : IEquatable<TRevisionId>, IComparable<TRevisionId>, IComparable, TValue
            where TKey           : IEquatable<TKey>,        IComparable<TKey>,        IComparable
            where TDatastructure : IDictionary<TKey, TValue>
            where S              : IPropertyElement<TId, TRevisionId, TKey, TValue, TDatastructure>

        {

            var _Pipe = new PropertyPipe<TId, TRevisionId, TKey, TValue, S, E>(myKeys);
            _Pipe.SetSourceCollection(myIEnumerable);

            return _Pipe;

        }

        #endregion

    }

}
