using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class CardinalOrdinalDirectionExtensions_Adjacent
    {
        static public CardinalOrdinalDirection GetNext(this CardinalOrdinalDirection item, RotationDirection direction)
        {
            switch (direction)
            {
                case RotationDirection.Clockwise: return item.GetClockwiseNext();
                case RotationDirection.CounterClockwise: return item.GetCounterClockwiseNext();
            }

            throw new UnaccountedBranchException("direction", direction);
        }

        static public CardinalOrdinalDirection GetPrevious(this CardinalOrdinalDirection item, RotationDirection direction)
        {
            switch (direction)
            {
                case RotationDirection.Clockwise: return item.GetClockwisePrevious();
                case RotationDirection.CounterClockwise: return item.GetCounterClockwisePrevious();
            }

            throw new UnaccountedBranchException("direction", direction);
        }

        static public CardinalOrdinalDirection GetCounterClockwiseNext(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return CardinalOrdinalDirection.RightUp;
                case CardinalOrdinalDirection.RightUp: return CardinalOrdinalDirection.Up;
                case CardinalOrdinalDirection.Up: return CardinalOrdinalDirection.LeftUp;
                case CardinalOrdinalDirection.LeftUp: return CardinalOrdinalDirection.Left;
                case CardinalOrdinalDirection.Left: return CardinalOrdinalDirection.LeftDown;
                case CardinalOrdinalDirection.LeftDown: return CardinalOrdinalDirection.Down;
                case CardinalOrdinalDirection.Down: return CardinalOrdinalDirection.RightDown;
                case CardinalOrdinalDirection.RightDown: return CardinalOrdinalDirection.Right;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public CardinalOrdinalDirection GetClockwisePrevious(this CardinalOrdinalDirection item)
        {
            return item.GetCounterClockwiseNext();
        }

        static public CardinalOrdinalDirection GetClockwiseNext(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return CardinalOrdinalDirection.RightDown;
                case CardinalOrdinalDirection.RightDown: return CardinalOrdinalDirection.Down;
                case CardinalOrdinalDirection.Down: return CardinalOrdinalDirection.LeftDown;
                case CardinalOrdinalDirection.LeftDown: return CardinalOrdinalDirection.Left;
                case CardinalOrdinalDirection.Left: return CardinalOrdinalDirection.LeftUp;
                case CardinalOrdinalDirection.LeftUp: return CardinalOrdinalDirection.Up;
                case CardinalOrdinalDirection.Up: return CardinalOrdinalDirection.RightUp;
                case CardinalOrdinalDirection.RightUp: return CardinalOrdinalDirection.Right;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public CardinalOrdinalDirection GetCounterClockwisePrevious(this CardinalOrdinalDirection item)
        {
            return item.GetClockwiseNext();
        }
    }
}