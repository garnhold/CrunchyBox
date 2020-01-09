using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class HoldableExtensions_Get
    {
        static public HoldingContainer<P> GetHoldingContainer<P>(this Holdable<P> item)
        {
            FieldInfoEX field_info;

            if (item.TryGetHoldingContainerField<P>(out field_info))
                return field_info.GetValue(item) as HoldingContainer<P>;

            return null;
        }

        static public P GetHolder<P>(this Holdable<P> item)
        {
            return item.GetHoldingContainer<P>().IfNotNull(c => c.GetParent());
        }
    }
}