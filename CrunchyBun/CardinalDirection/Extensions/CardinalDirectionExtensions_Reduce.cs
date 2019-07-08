using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class CardinalDirectionExtensions_Reduce
    {
        static public CardinalDirection ReduceToLeftOrRight(this CardinalDirection item)
        {
            switch (item)
            {
                case CardinalDirection.Down: return CardinalDirection.Left;
                case CardinalDirection.Left: return CardinalDirection.Left;

                case CardinalDirection.Right: return CardinalDirection.Right;
                case CardinalDirection.Up: return CardinalDirection.Right;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public CardinalDirection ReduceToUpOrDown(this CardinalDirection item)
        {
            switch (item)
            {
                case CardinalDirection.Down: return CardinalDirection.Down;
                case CardinalDirection.Left: return CardinalDirection.Down;

                case CardinalDirection.Right: return CardinalDirection.Up;
                case CardinalDirection.Up: return CardinalDirection.Up;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}