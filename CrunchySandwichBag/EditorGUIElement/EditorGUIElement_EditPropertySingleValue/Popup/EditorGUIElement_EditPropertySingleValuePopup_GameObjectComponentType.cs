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
    public class EditorGUIElement_EditPropertySingleValuePopup_GameObjectComponentType : EditorGUIElement_EditPropertySingleValuePopup<Type>
    {
        private EditProperty_Single_Value game_object_property;

        public EditorGUIElement_EditPropertySingleValuePopup_GameObjectComponentType(EditProperty_Single_Value p, EditProperty_Single_Value g) : base(p)
        {
            game_object_property = g;
        }

        public override IEnumerable<Type> GetOptions()
        {
            GameObject game_object;

            if (game_object_property.TryGetContentValues(out game_object))
                return game_object.IfNotNull(g => g.GetAllComponents().Convert(c => c.GetType()).Unique());

            return Empty.IEnumerable<Type>();
        }
    }
}