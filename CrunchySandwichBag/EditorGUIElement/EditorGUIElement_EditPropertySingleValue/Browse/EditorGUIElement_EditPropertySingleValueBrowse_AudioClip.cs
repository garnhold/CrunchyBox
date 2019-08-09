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

        protected override EditorGUIElement CreateAssetInfoElement(AssetInfo info)
        {
            EditorGUIElement_Container_Flow_Line container = new EditorGUIElement_Container_Flow_Line();

            container.AddWeightedChild(0.8f, new EditorGUIElement_Button(info.GetName(), delegate() {
                info.Resolve<AudioClip>().PlaySample();
            }));
            
            container.AddWeightedChild(0.2f, new EditorGUIElement_Button("Select", delegate() {
                GetProperty().SetContentValues(info.Resolve<AudioClip>());
            }));

            return container;
        }

        public EditorGUIElement_EditPropertySingleValueBrowse_AudioClip(EditProperty_Single_Value p) : base(p) { }
    }
}