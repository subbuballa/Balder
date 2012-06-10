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
using System.Linq;
using System.Text;
using System.Collections.Generic;

using de.ahzf.Illias.Commons.Collections;
using de.ahzf.Vanaheimr.Styx;

#endregion

namespace de.ahzf.Vanaheimr.Balder
{

    #region PropertyPipeExtentions
    
    /// <summary>
    /// Extention methods for the PropertyPipe.
    /// </summary>
    public static class PropertyPipeExtentions
    {

        #region P<TKey, TValue>(this IEnumerable<IReadOnlyProperties<...>>, Keys)

        /// <summary>
        /// The PropertyPipe returns the values for the given property keys.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <param name="IEnumerable">A IReadOnlyProperties&lt;TKey, TValue&gt; enumerable.</param>
        /// <param name="Keys">An array of property keys.</param>
        public static PropertyPipe<TKey, TValue> P<TKey, TValue>(this IEnumerable<IReadOnlyProperties<TKey, TValue>> IEnumerable,
                                                                 params TKey[] Keys)

            where TKey : IEquatable<TKey>, IComparable<TKey>, IComparable

        {
            return new PropertyPipe<TKey, TValue>(IEnumerable: IEnumerable, Keys: Keys);
        }

        #endregion

        #region P<TKey, TValue>(this IEnumerator<IReadOnlyProperties<...>>, Keys)

        /// <summary>
        /// The PropertyPipe returns the values for the given property keys.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <param name="IEnumerator">A IReadOnlyProperties&lt;TKey, TValue&gt; enumerator.</param>
        /// <param name="Keys">An array of property keys.</param>
        public static PropertyPipe<TKey, TValue> P<TKey, TValue>(this IEnumerator<IReadOnlyProperties<TKey, TValue>> IEnumerator,
                                                                 params TKey[] Keys)

            where TKey : IEquatable<TKey>, IComparable<TKey>, IComparable

        {
            return new PropertyPipe<TKey, TValue>(IEnumerator: IEnumerator, Keys: Keys);
        }

        #endregion

    }

    #endregion

    #region PropertyPipe<TKey, TValue>

    /// <summary>
    /// The PropertyPipe returns the property value of the
    /// Element identified by the provided key.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys.</typeparam>
    /// <typeparam name="TValue">The type of the values.</typeparam>
    public class PropertyPipe<TKey, TValue> : AbstractPipe<IReadOnlyProperties<TKey, TValue>, TValue>
        
        where TKey : IEquatable<TKey>, IComparable<TKey>, IComparable

    {

        #region Data

        private readonly TKey[] Keys;
        private IEnumerator<TKey> TmpInterator;

        #endregion

        #region Constructor(s)

        #region PropertyPipe(Keys)

        /// <summary>
        /// Creates a new PropertyPipe.
        /// </summary>
        /// <param name="Keys">The property keys.</param>
        public PropertyPipe(params TKey[] Keys)
        {
            this.Keys = Keys;
        }

        #endregion

        #region PropertyPipe(IEnumerable = null, IEnumerator = null, Keys)

        /// <summary>
        /// Creates a new PropertyPipe.
        /// </summary>
        /// <param name="IEnumerable">An optional IEnumerable&lt;IIdentifier&lt;TId&gt;&gt; as element source.</param>
        /// <param name="IEnumerator">An optional IEnumerator&lt;IIdentifier&lt;TId&gt;&gt; as element source.</param>
        /// <param name="Keys">The property keys.</param>
        public PropertyPipe(IEnumerable<IReadOnlyProperties<TKey, TValue>> IEnumerable = null,
                            IEnumerator<IReadOnlyProperties<TKey, TValue>> IEnumerator = null,
                            params TKey[] Keys)

            : base(IEnumerable, IEnumerator)

        {
            this.Keys = Keys;
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

                if (TmpInterator == null)
                {

                    if (_InternalEnumerator.MoveNext())
                        TmpInterator = Keys.ToList().GetEnumerator();

                    else
                        return false;

                }

                if (TmpInterator.MoveNext())
                {

                    if (_InternalEnumerator.Current.TryGetProperty(TmpInterator.Current, out _CurrentElement))
                        return true;

                    return false;

                }

                TmpInterator = null;

            }

        }

        #endregion


        #region ToString()

        /// <summary>
        /// A string representation of this pipe.
        /// </summary>
        public override String ToString()
        {

            var _StringBuilder = new StringBuilder();

            foreach (var _Key in Keys)
                _StringBuilder.Append(_Key.ToString() + ", ");

            if (_StringBuilder.Length >= 2)
                _StringBuilder.Length = _StringBuilder.Length - 2;

            return base.ToString() + "<" + _StringBuilder.ToString() + ">";

        }

        #endregion

    }

    #endregion

}
