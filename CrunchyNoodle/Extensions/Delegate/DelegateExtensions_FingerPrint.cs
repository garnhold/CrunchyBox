using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class DelegateExtensions_FingerPrint
    {
        static public int GetDelegateFingerPrint(this Delegate item)
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + item.Target.GetFingerPrintEX();
                hash = hash * 23 + item.Method.GetHashCode();
                return hash;
            }
        }

        static public bool IsDelegateFingerEquivolent(this Delegate item, Delegate target)
        {
            if (item.Method == target.Method)
            {
                if (item.Target.IsFingerEquivolentEX(target.Target))
                    return true;
            }

            return false;
        }
    }
}