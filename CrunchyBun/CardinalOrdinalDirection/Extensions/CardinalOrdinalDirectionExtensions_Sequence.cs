using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class CardinalOrdinalDirectionExtensions_Sequence
    {
        static public IEnumerable<CardinalOrdinalDirection> GetSequenceTo(this CardinalOrdinalDirection item, CardinalOrdinalDirection target, RotationDirection direction)
        {
            return item.TraverseLoop(z => z.GetNext(direction))
                .EndAfter(target)
                .Prepend(item);
        }
        static public IEnumerable<CardinalOrdinalDirection> GetFullRotationSequence(this CardinalOrdinalDirection item, RotationDirection direction)
        {
            return item.GetSequenceTo(item, direction);
        }
    }
}