using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_Loop
    {
        static public IEnumerable<VectorF2> CloseClockwiseLoop(this IEnumerable<VectorF2> item)
        {
            return item.WindClockwise().CloseLoop();
        }
        static public IEnumerable<VectorF2> CloseCounterClockwiseLoop(this IEnumerable<VectorF2> item)
        {
            return item.WindCounterClockwise().CloseLoop();
        }

        static public bool IsLoopClockwise(this IEnumerable<VectorF2> item)
        {
            if (item.GetLoopShoelaceArea() < 0.0f)
                return true;

            return false;
        }
        static public bool IsLoopCounterClockwise(this IEnumerable<VectorF2> item)
        {
            if (item.IsLoopClockwise() == false)
                return true;

            return false;
        }
    }
}