using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class GamepadEventHistoryExtensions_Frame
    {
        static public bool IsCurrentEventOccuringThisFrame<T>(this GamepadEventHistory<T> item)
        {
            return item.GetCurrentEvent().IfNotNull(e => e.IsOccuringThisFrame());
        }

        static public bool IsEventOccuringThisFrame<T>(this GamepadEventHistory<T> item, Predicate<GamepadEventHistory<T>> predicate)
        {
            if (item.IsCurrentEventOccuringThisFrame())
            {
                if (predicate(item))
                    return true;
            }

            return false;
        }

        static public bool IsEventSequenceOccuringThisFrame<T>(this GamepadEventHistory<T> item, ICollection<T> sequence)
        {
            if (item.IsEventOccuringThisFrame(h => h.AreCurrentAndPastValuesEqual(sequence)))
                return true;

            return false;
        }
        static public bool IsEventSequenceOccuringThisFrame<T>(this GamepadEventHistory<T> item, params T[] sequence)
        {
            return item.IsEventSequenceOccuringThisFrame((ICollection<T>)sequence);
        }
        static public bool IsEventSequenceOccuringThisFrame<T>(this GamepadEventHistory<T> item, IEnumerable<T> sequence)
        {
            return item.IsEventSequenceOccuringThisFrame(sequence.ToList());
        }
    }
}