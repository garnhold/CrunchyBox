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
using Slider = CrunchySandwichBag.EditorGUIElement_Single_SerializedProperty_Slider;
using Button = CrunchySandwichBag.EditorGUIElement_Single_Button;
using Foldout = CrunchySandwichBag.EditorGUIElement_Foldout_SerializedProperty_VerticalStrip;

using Indent = CrunchySandwichBag.EditorGUIElementAttachment_Singular_Padding_Indent;

using ChangeListener = CrunchySandwichBag.EditorGUIElementAttachment_ChangeListener;

using FixedLength = CrunchySandwichBag.EditorGUIElementLength_Fixed;
using WeightedLength = CrunchySandwichBag.EditorGUIElementLength_Weighted;

namespace CrunchySandwichBag
{
    [CustomEditor(typeof(SpriteCollider2D))]
    public class SpriteCollider2DEditor : EditorEX_Simple<SpriteCollider2D>
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SpriteCollider2D item, SerializedObject serialized_object)
        {
            Row sprite_row = root.AddChild(new Row());

            sprite_row.AddLabeledChild("Sprite", new WeightedLength(1.0f), new Field(serialized_object.FindProperty("sprite")))
                .AddAttachment(new ChangeListener(() => item.DirtyGeometry()));

            sprite_row.AddChild(new FixedLength(64.0f), new Button("Auto", () => item.SetSpriteAutomatically()));

            root.AddLabeledChild("Max Sweep Deviance", new Slider(serialized_object.FindProperty("sweep_deviance"), 1.0f, 16.0f));

            Column additional_parameters = root.AddChild(new Foldout(serialized_object.FindProperty("is_show_all_parameters"), "Additional Parameters")).GetContainer();

            additional_parameters.AddLabeledChild("Alpha Threshold", new Slider(serialized_object.FindProperty("alpha_threshold"), 0.01f, 1.0f))
                    .AddAttachment(new ChangeListener(() => item.DirtyGeometry()));
            additional_parameters.AddLabeledChild("Max Bisection Deviance", new Slider(serialized_object.FindProperty("bisection_deviance"), 1.0f, 5.0f));
            additional_parameters.AddLabeledChild("Min Length", new Slider(serialized_object.FindProperty("minimum_length"), 0.0f, 16.0f));
            additional_parameters.AddLabeledChild("Min S2L Ratio", new Slider(serialized_object.FindProperty("minimum_shortest_to_longest_ratio"), 0.0f, 0.025f));

            root.AddAttachment(new ChangeListener(delegate() {
                item.UpdateGeometry(item.GetSprite().GetAssetLastWriteDate(), delegate() {
                    return item.GetSprite().Sideload().CreateSolidGrid(item.GetAlphaThreshold());
                });
            }));

            root.AddAttachment(new EditorGUIElementAttachment_SerializedObjectSection(serialized_object));
        }
    }
}