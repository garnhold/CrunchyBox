using System;

namespace CrunchyDough
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