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
    [CustomPropertyDrawer(typeof(ValueCurve))]
    public class ValueCurveDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            Column range_column = new Column();

            root.AddChild(new Row())
                .Chain(r => r.AddWeightedChild(0.9f, new Field(property.FindPropertyRelative("curve"))))
                .Chain(r => r.AddWeightedChild(0.1f, range_column));

            range_column.AddChildren(
                new Field(property.FindPropertyRelative("range_end")),
                new Field(property.FindPropertyRelative("range_start"))
            );

            root.AddChild(new Row())
                .Chain(r => r.AddWeightedChild(1.0f, new Field(property.FindPropertyRelative("domain_start"))))
                .Chain(r => r.AddWeightedChild(1.0f, new Field(property.FindPropertyRelative("domain_end"))));
        }
    }
}