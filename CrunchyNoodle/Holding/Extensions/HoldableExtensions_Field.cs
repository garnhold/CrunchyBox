using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class HoldableExtensions_Field
    {
        static public bool TryGetHoldingContainerField<P>(this Holdable<P> item, out FieldInfoEX field_info)
        {
            return item.GetFilteredInstanceFields(
                Filterer_FieldInfo.CanBeTreatedAs<HoldingContainer<P>>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<HoldingContainerAttribute>()
            ).TryGetFirst(out field_info);
        }
    }
}