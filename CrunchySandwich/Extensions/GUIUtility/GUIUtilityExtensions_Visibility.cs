using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public partial class GUIUtilityExtensions
    {
        static private OperationCache<ValueGetter<Rect>> GET_VISIBLE_RECT_VALUE_GETTER = ReflectionCache.Get().NewOperationCache("GET_VISIBLE_RECT_VALUE_GETTER", delegate () {
            return typeof(GUIUtility).Assembly
                .GetAllDefinedTypes()
                .FindFirst(t => t.Name == "GUIClip")
                .GetStaticMethod("get_visibleRect")
                .GetSimulatedValueGetter<Rect>();
        });
        static public Rect GetVisibleRect()
        {
            return GET_VISIBLE_RECT_VALUE_GETTER.Fetch()(null);
        }
    }
}