﻿using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class RandIntSource_System : RandIntSource
    {
        private Random random;

        public RandIntSource_System(Random r)
        {
            random = r;
        }

        public override int Get()
        {
            return random.Next();
        }
    }
}