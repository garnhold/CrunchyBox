using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public struct IslandInfo
    {
        public readonly int start;
        public readonly int end;

        public IslandInfo(int s, int e)
        {
            start = s;
            end = e;
        }
    }
}