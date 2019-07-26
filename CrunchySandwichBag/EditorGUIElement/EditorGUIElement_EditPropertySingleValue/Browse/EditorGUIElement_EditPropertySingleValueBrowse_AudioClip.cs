using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(AudioClip), true)]
    public class EditorGUIElement_EditPropertySingleValueBrowse_AudioClip : EditorGUIElement_EditPropertySingleValueBrowse<AudioClip>
    {
        protected override AudioClip DrawValueInternal(Rect rect, AudioClip value)
        {
            Rect play_rect;

            rect.SplitByXRightOffset(45.0f, out rect, out play_rect);

            if (GUI.Button(play_rect, "Play"))
                value.PlaySample();

            return base.DrawValueInternal(rect, value);
        }

        protected override EditorGUIElement CreateAssetElement(AudioClip asset)
        {
            EditorGUIElement_Container_HorizontalStrip container = new EditorGUIElement_Container_HorizontalStrip();

            container.AddChild(1.0f, new EditorGUIElement_Button(asset.name, delegate() {
                asset.PlaySample();
            }));
            
            container.AddChild(0.2f, new EditorGUIElement_Button("Select", delegate() {
                GetProperty().SetContentValues(asset);
            }));

            return container;
        }

        public EditorGUIElement_EditPropertySingleValueBrowse_AudioClip(EditProperty_Single_Value p) : base(p) { }
    }
}