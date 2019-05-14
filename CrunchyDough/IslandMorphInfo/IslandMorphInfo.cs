using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public struct IslandMorphInfo
    {
        public readonly IslandInfo remove_range;

        public readonly int insert_index;
        public readonly IslandInfo insert_range;

        public IslandMorphInfo(IslandInfo rr, int i, IslandInfo ir)
        {
            remove_range = rr;

            insert_index = i;
            insert_range = ir;
        }
    }
}