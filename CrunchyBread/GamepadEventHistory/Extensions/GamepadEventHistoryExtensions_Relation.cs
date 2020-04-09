using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadEventHistoryExtensions_Relation
    {
        static public bool AreCurrentAndPastEvents<T, J>(this GamepadEventHistory<T> item, ICollection<J> sequence, Relation<GamepadEvent<T>, J> relation)
        {
            return item.GetCurrentAndPastEvents(sequence.Count)
                .AreElements(sequence, relation);
        }
        static public bool AreCurrentAndPastEvents<T, J>(this GamepadEventHistory<T> item, IEnumerable<J> sequence, Relation<GamepadEvent<T>, J> relation)
        {
            return item.AreCurrentAndPastEvents(sequence.ToList(), relation);
        }

        static public bool AreCurrentAndPastValues<T, J>(this GamepadEventHistory<T> item, ICollection<J> sequence, Relation<T, J> relation)
        {
            return item.AreCurrentAndPastEvents(sequence, (e, o) => relation(e.GetValue(), o));
        }
        static public bool AreCurrentAndPastValues<T, J>(this GamepadEventHistory<T> item, IEnumerable<J> sequence, Relation<T, J> relation)
        {
            return item.AreCurrentAndPastValues(sequence.ToList(), relation);
        }

        static public bool AreCurrentAndPastValuesEqual<T>(this GamepadEventHistory<T> item, ICollection<T> sequence)
        {
            return item.AreCurrentAndPastValues(sequence, (e, o) => e.EqualsEX(o));
        }
        static public bool AreCurrentAndPastValuesEqual<T>(this GamepadEventHistory<T> item, params T[] sequence)
        {
            return item.AreCurrentAndPastValuesEqual((ICollection<T>)sequence);
        }
        static public bool AreCurrentAndPastValuesEqual<T>(this GamepadEventHistory<T> item, IEnumerable<T> sequence)
        {
            return item.AreCurrentAndPastValuesEqual(sequence.ToList());
        }
    }
}