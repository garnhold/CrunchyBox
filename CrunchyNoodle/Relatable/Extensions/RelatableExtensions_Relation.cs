using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class RelatableExtensions_Relation
    {
        static public bool IsChildOf(this Relatable item, Relatable parent)
        {
            if (item.GetParents<Relatable>().Has(parent))
                return true;

            return false;
        }

        static public bool IsParentOf(this Relatable item, Relatable child)
        {
            if (child != null)
            {
                if (child.IsChildOf(item))
                    return true;
            }

            return false;
        }
    }
}