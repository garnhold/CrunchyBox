using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(Type))]
    public class EditorGUIElement_EditPropertySingleValue_Combo_Type: EditorGUIElement_EditPropertySingleValue_Combo<Type>
    {
        public EditorGUIElement_EditPropertySingleValue_Combo_Type(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<Type> GetOptions(string text)
        {
            return Types.GetFilteredTypes(
                Filterer_Type.DoesNameContain(text)
            );
        }
    }
}