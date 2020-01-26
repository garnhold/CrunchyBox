using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_IEnumerable_Loop
    {
        static public IEnumerable<Vector2> CloseClockwiseLoop(this IEnumerable<Vector2> item)
        {
            return item.WindClockwise().CloseLoop();
        }
        static public IEnumerable<Vector2> CloseCounterClockwiseLoop(this IEnumerable<Vector2> item)
        {
            return item.WindCounterClockwise().CloseLoop();
        }

        static public bool IsLoopClockwise(this IEnumerable<Vector2> item)
        {
            if (item.GetLoopShoelaceArea() < 0.0f)
                return true;

            return false;
        }
        static public bool IsLoopCounterClockwise(this IEnumerable<Vector2> item)
        {
            if (item.IsLoopClockwise() == false)
                return true;

            return false;
        }
    }
}