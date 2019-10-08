using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(Type))]
    public class EditorGUIElement_EditPropertySingleValue_Combo_Type: EditorGUIElement_EditPropertySingleValue_Combo<Type>
    {
        public EditorGUIElement_EditPropertySingleValue_Combo_Type(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<Type> GetOptions(string text)
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.DoesNameContain(text)
            );
        }
    }
}