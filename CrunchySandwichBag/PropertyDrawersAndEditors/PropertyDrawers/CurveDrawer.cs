using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using Crunchy.Dough;
using Crunchy.Sandwich;

using Column = Crunchy.SandwichBag.EditorGUIElement_Container_Auto_Simple_VerticalStrip;
using Row = Crunchy.SandwichBag.EditorGUIElement_Container_Flow_Line;
using Grid = Crunchy.SandwichBag.EditorGUIElement_Container_Auto_Simple_Grid;
using Field = Crunchy.SandwichBag.EditorGUIElement_Complex_SerializedProperty_FieldEX;
using FloatSequence = Crunchy.SandwichBag.EditorGUIElement_SerializedProperty_FloatSequence;
using Slider = Crunchy.SandwichBag.EditorGUIElement_Single_SerializedProperty_Slider;
using Foldout = Crunchy.SandwichBag.EditorGUIElement_Foldout_SerializedProperty<Crunchy.SandwichBag.EditorGUIElement_Container_Auto_Simple_VerticalStrip>;

namespace Crunchy.SandwichBag
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