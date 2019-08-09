﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(Checktoid), true)]
    public class EditorGUIElement_Composite_EditPropertySingleValue_Checktoid : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
            EditTarget target = GetProperty().GetContents();

            EditorGUIElement_Container_Flow_Line container = new EditorGUIElement_Container_Flow_Line();

            container.AddFixedChild(100.0f,
                target.ForceProperty("target").CreateEditorGUIElement()
            );
            
            container.AddWeightedChild(1.0f,
                target.ForcePropertyValue("preditoid").CreateEditorGUIElement()
            );

            return container;
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_Checktoid(EditProperty_Single_Value p) : base(p) { }
    }
}