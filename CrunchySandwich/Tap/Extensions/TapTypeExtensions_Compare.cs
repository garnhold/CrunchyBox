using System;

namespace CrunchySandwich
{
    static public class TapTypeExtensions_Compare
    {
        static public bool IsSubstantial(this TapType item)
        {
            switch (item)
            {
                case TapType.LongTap:
                case TapType.ShortTap:
                    return true;
            }

            return false;
        }
    }
}