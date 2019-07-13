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
    public abstract class EditorGUIElement_Composite_EditPropertyValue : EditorGUIElement_Composite
    {
        private EditProperty_Value property;

        public EditorGUIElement_Composite_EditPropertyValue(EditorGUIElement e, EditProperty_Value p) : base(e)
        {
            property = p;
        }

        public EditProperty_Value GetEditPropertyValue()
        {
            return property;
        }
    }
}