using System;

namespace CrunchyDough
{
    static public class IntExtensions_Congruent
    {
        static public int GetACongruent(this int item)
        {
            unchecked
            {
                return 22695477 * item + 1;
            }
        }
    }
}