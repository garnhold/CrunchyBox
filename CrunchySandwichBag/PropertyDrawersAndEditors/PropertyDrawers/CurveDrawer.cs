using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

using Column = CrunchySandwichBag.EditorGUIElement_Container_Auto_Simple_VerticalStrip;
using Row = CrunchySandwichBag.EditorGUIElement_Container_HorizontalStrip;
using Grid = CrunchySandwichBag.EditorGUIElement_Container_Auto_Simple_Grid;
using Field = CrunchySandwichBag.EditorGUIElement_Complex_SerializedProperty_FieldEX;
using FloatSequence = CrunchySandwichBag.EditorGUIElement_SerializedProperty_FloatSequence;
using Slider = CrunchySandwichBag.EditorGUIElement_Single_SerializedProperty_Slider;
using Foldout = CrunchySandwichBag.EditorGUIElement_Foldout_SerializedProperty<CrunchySandwichBag.EditorGUIElement_Container_Auto_Simple_VerticalStrip>;

namespace CrunchySandwichBag
{
    [CustomPropertyDrawer(typeof(Curve))]
    public class CurveDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new Field(property.FindPropertyRelative("percents.Array.size")).LabelWithGUIContent("Resolution"));
            root.AddChild(new FloatSequence(property.FindPropertyRelative("percents")));
        }
    }
}