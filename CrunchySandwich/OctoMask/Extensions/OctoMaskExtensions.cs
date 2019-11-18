using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class OctoMaskExtensions
    {
        static public int GetBitIndex(int dx, int dy)
        {
            switch(dy)
            {
                case -1:
                    switch (dx)
                    {
                        case -1: return 0;
                        case 0: return 1;
                        case 1: return 2;
                    }
                    break;

                case 0:
                    switch (dx)
                    {
                        case -1: return 3;
                        case 1: return 4;
                    }
                    break;

                case 1:
                    switch (dx)
                    {
                        case -1: return 5;
                        case 0: return 6;
                        case 1: return 7;
                    }
                    break;
            }

            return -1;
        }
        static public bool TryGetBitIndex(int dx, int dy, out int index)
        {
            index = GetBitIndex(dx, dy);

            if (index != -1)
                return true;

            return false;
        }

        static public byte GetBitValue(int dx, int dy)
        {
            int index;

            if (TryGetBitIndex(dx, dy, out index))
                return ByteBits.GetNthBitValue(index);

            return 0;
        }
    }
}