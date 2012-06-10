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

using de.ahzf.Illias.Commons;
using de.ahzf.Vanaheimr.Styx;

#endregion

namespace de.ahzf.Vanaheimr.Balder
{

    #region RevIdPipeExtensions

    /// <summary>
    /// Extension methods for the RevIdPipe.
    /// </summary>
    public static class RevIdPipeExtensions
    {

        #region RevIds<TRevId>(this IEnumerable)

        /// <summary>
        /// The RevIdPipe will return the RevIds of the
        /// given revision identifiable objects.
        /// </summary>
        /// <typeparam name="TRevId">The type of the RevIds.</typeparam>
        /// <param name="IEnumerable">An enumeration of revision identifiable objects.</param>
        /// <returns>An enumeration of RevIds.</returns>
        public static RevIdPipe<TRevId> RevIds<TRevId>(this IEnumerable<IRevisionId<TRevId>> IEnumerable)

            where TRevId : IEquatable<TRevId>, IComparable<TRevId>, IComparable

        {
            return new RevIdPipe<TRevId>(IEnumerable);
        }

        #endregion

    }

    #endregion

    #region RevIdPipe<TId>

    /// <summary>
    /// The RevIdPipe will return the RevIds of the
    /// given revision identifiable objects.
    /// </summary>
    public class RevIdPipe<TRevId> : AbstractPipe<IRevisionId<TRevId>, TRevId>
        
        where TRevId : IEquatable<TRevId>, IComparable<TRevId>, IComparable

    {

        #region Constructor(s)

        #region RevIdPipe(IEnumerable = null, IEnumerator = null)

        /// <summary>
        /// Creates a new RevIdPipe emitting the RevIds of the
        /// given revision identifiable objects.
        /// </summary>
        /// <param name="IEnumerable">An optional IEnumerable&lt;IIdentifier&lt;TId&gt;&gt; as element source.</param>
        /// <param name="IEnumerator">An optional IEnumerator&lt;IIdentifier&lt;TId&gt;&gt; as element source.</param>
        public RevIdPipe(IEnumerable<IRevisionId<TRevId>> IEnumerable = null,
                         IEnumerator<IRevisionId<TRevId>> IEnumerator = null)

            : base(IEnumerable, IEnumerator)

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

            if (_InternalEnumerator.MoveNext())
            {
                _CurrentElement = _InternalEnumerator.Current.RevId;
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

    #endregion

}
