﻿using System;

namespace Crunchy.Dough
{
    static public class RandChance
    {
        static public readonly RandChanceSource SOURCE = new RandChanceSource(RandFloat.SOURCE);

        static public bool Get(float chance)
        {
            return SOURCE.Get(chance);
        }
    }
}