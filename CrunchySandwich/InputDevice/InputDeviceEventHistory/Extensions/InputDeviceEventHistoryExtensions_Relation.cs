using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class InputDeviceEventHistoryExtensions_Relation
    {
        static public bool AreCurrentAndPastEvents<T, J>(this InputDeviceEventHistory<T> item, ICollection<J> sequence, Relation<InputDeviceEvent<T>, J> relation)
        {
            return item.GetCurrentAndPastEvents(sequence.Count)
                .AreElements(sequence, relation);
        }
        static public bool AreCurrentAndPastEvents<T, J>(this InputDeviceEventHistory<T> item, IEnumerable<J> sequence, Relation<InputDeviceEvent<T>, J> relation)
        {
            return item.AreCurrentAndPastEvents(sequence.ToList(), relation);
        }

        static public bool AreCurrentAndPastValues<T, J>(this InputDeviceEventHistory<T> item, ICollection<J> sequence, Relation<T, J> relation)
        {
            return item.AreCurrentAndPastEvents(sequence, (e, o) => relation(e.GetValue(), o));
        }
        static public bool AreCurrentAndPastValues<T, J>(this InputDeviceEventHistory<T> item, IEnumerable<J> sequence, Relation<T, J> relation)
        {
            return item.AreCurrentAndPastValues(sequence.ToList(), relation);
        }

        static public bool AreCurrentAndPastValuesEqual<T>(this InputDeviceEventHistory<T> item, ICollection<T> sequence)
        {
            return item.AreCurrentAndPastValues(sequence, (e, o) => e.EqualsEX(o));
        }
        static public bool AreCurrentAndPastValuesEqual<T>(this InputDeviceEventHistory<T> item, params T[] sequence)
        {
            return item.AreCurrentAndPastValuesEqual((ICollection<T>)sequence);
        }
        static public bool AreCurrentAndPastValuesEqual<T>(this InputDeviceEventHistory<T> item, IEnumerable<T> sequence)
        {
            return item.AreCurrentAndPastValuesEqual(sequence.ToList());
        }
    }
}