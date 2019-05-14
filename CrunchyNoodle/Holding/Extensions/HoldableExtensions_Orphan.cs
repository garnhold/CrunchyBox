using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class HoldableExtensions_Utility
    {
        static public void OrphanHoldable<P>(this Holdable<P> item)
        {
            item.GetHoldingContainer<P>().IfNotNull(c => c.Remove(item));
        }

        static public bool IsOrphanHoldable<P>(this Holdable<P> item)
        {
            if (item.GetHolder() == null)
                return true;

            return false;
        }
    }
}