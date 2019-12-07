using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class CardinalOrdinalDirectionExtensions_Vector2
    {
        static public Vector2 GetVector2(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return new Vector2(1.0f, 0.0f);
                case CardinalOrdinalDirection.RightUp: return new Vector2(Mathq.DIAGONAL, Mathq.DIAGONAL);
                case CardinalOrdinalDirection.Up: return new Vector2(0.0f, 1.0f);
                case CardinalOrdinalDirection.LeftUp: return new Vector2(-Mathq.DIAGONAL, Mathq.DIAGONAL);
                case CardinalOrdinalDirection.Left: return new Vector2(-1.0f, 0.0f);
                case CardinalOrdinalDirection.LeftDown: return new Vector2(-Mathq.DIAGONAL, -Mathq.DIAGONAL);
                case CardinalOrdinalDirection.Down: return new Vector2(0.0f, -1.0f);
                case CardinalOrdinalDirection.RightDown: return new Vector2(Mathq.DIAGONAL, -Mathq.DIAGONAL);
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}