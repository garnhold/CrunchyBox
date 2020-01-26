using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_Foldout_EditPropertySingleValue_VerticalStrip : EditorGUIElement_Foldout_EditPropertySingleValue<EditorGUIElement_Container_Auto_Simple_VerticalStrip>
    {
        public EditorGUIElement_Foldout_EditPropertySingleValue_VerticalStrip(EditProperty_Single_Value s, string t, float h) : base(s, t, new EditorGUIElement_Container_Auto_Simple_VerticalStrip(), h) { }
        public EditorGUIElement_Foldout_EditPropertySingleValue_VerticalStrip(EditProperty_Single_Value s, string t) : this(s, t, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}