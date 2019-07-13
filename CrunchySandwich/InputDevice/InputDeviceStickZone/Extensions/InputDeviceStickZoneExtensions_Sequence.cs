using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceStickZoneExtensions_Sequence
    {
        static public IEnumerable<InputDeviceStickZone> GetClockwiseSequenceTo(this InputDeviceStickZone item, InputDeviceStickZone target)
        {
            return item.TraverseLoop(z => z.GetClockwiseNext())
                .EndAfter(target)
                .Prepend(item);
        }
        static public IEnumerable<InputDeviceStickZone> GetFullClockwiseRotationSequence(this InputDeviceStickZone item)
        {
            return item.GetClockwiseSequenceTo(item);
        }

        static public IEnumerable<InputDeviceStickZone> GetCounterClockwiseSequenceTo(this InputDeviceStickZone item, InputDeviceStickZone target)
        {
            return item.TraverseLoop(z => z.GetCounterClockwiseNext())
                .EndAfter(target)
                .Prepend(item);
        }
        static public IEnumerable<InputDeviceStickZone> GetFullCounterClockwiseSequenceTo(this InputDeviceStickZone item)
        {
            return item.GetCounterClockwiseSequenceTo(item);
        }
    }
}