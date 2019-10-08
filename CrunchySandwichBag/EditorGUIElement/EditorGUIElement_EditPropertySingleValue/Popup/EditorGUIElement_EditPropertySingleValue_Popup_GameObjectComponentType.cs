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
    public class EditorGUIElement_EditPropertySingleValue_Popup_GameObjectComponentType : EditorGUIElement_EditPropertySingleValue_Popup<Type>
    {
        private EditProperty_Single_Value game_object_property;

        public EditorGUIElement_EditPropertySingleValue_Popup_GameObjectComponentType(EditProperty_Single_Value p, EditProperty_Single_Value g) : base(p)
        {
            game_object_property = g;
        }

        public override IEnumerable<Type> GetOptions()
        {
            GameObject game_object;

            if (game_object_property.TryGetContentValues(out game_object))
                return game_object.GetAllComponents().Convert(c => c.GetType()).Unique();

            return Empty.IEnumerable<Type>();
        }
    }
}