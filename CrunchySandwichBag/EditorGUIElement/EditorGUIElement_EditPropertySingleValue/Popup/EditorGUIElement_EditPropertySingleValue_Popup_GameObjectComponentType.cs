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