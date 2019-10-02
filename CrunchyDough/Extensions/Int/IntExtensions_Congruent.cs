using System;

namespace CrunchyDough
{
    static public class IntExtensions_Congruent
    {
        public const int CongruentLookupSeed = 0;
        public const int CongruentLookupSize = 1024;

        static private int[] CONGRUENT_LOOKUP;

        static public int GetACongruent(this int item)
        {
            if (CONGRUENT_LOOKUP == null)
            {
                Random random = new Random(CongruentLookupSeed);

                CONGRUENT_LOOKUP = new int[CongruentLookupSize];

                for (int i = 0; i < CONGRUENT_LOOKUP.Length; i++)
                    CONGRUENT_LOOKUP[i] = random.Next();
            }

            return CONGRUENT_LOOKUP.GetLooped(item);
        }
    }
}