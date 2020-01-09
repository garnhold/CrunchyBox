using System;

namespace Crunchy.Dough
{
    static public class IntExtensions_POT
    {
        static public int CalculateContainerPOT(this int item)
        {
            int POT = item.GetHighestBitValue();

            if (item == POT)
                return POT;

            return POT << 1;
        }
    }
}