using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceEventHistoryExtensions_Frame
    {
        static public bool IsCurrentEventOccuringThisFrame<T>(this InputDeviceEventHistory<T> item)
        {
            return item.GetCurrentEvent().IfNotNull(e => e.IsOccuringThisFrame());
        }

        static public bool IsEventOccuringThisFrame<T>(this InputDeviceEventHistory<T> item, Predicate<InputDeviceEventHistory<T>> predicate)
        {
            if (item.IsCurrentEventOccuringThisFrame())
            {
                if (predicate(item))
                    return true;
            }

            return false;
        }

        static public bool IsEventSequenceOccuringThisFrame<T>(this InputDeviceEventHistory<T> item, IList<T> sequence)
        {
            if (item.IsEventOccuringThisFrame(h => h.AreCurrentAndPastValuesEqual(sequence)))
                return true;

            return false;
        }
        static public bool IsEventSequenceOccuringThisFrame<T>(this InputDeviceEventHistory<T> item, params T[] sequence)
        {
            return item.IsEventSequenceOccuringThisFrame((IList<T>)sequence);
        }
        static public bool IsEventSequenceOccuringThisFrame<T>(this InputDeviceEventHistory<T> item, IEnumerable<T> sequence)
        {
            return item.IsEventSequenceOccuringThisFrame(sequence.ToList());
        }
    }
}