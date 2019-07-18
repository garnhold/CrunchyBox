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
    [EditorGUIElementForType(typeof(TargetComponent), true)]
    public class EditorGUIElement_EditPropertyValue_TargetComponent : EditorGUIElement_EditPropertyValue<TargetComponent>
    {
        protected override TargetComponent DrawValueInternal(Rect rect, TargetComponent value)
        {
            Rect game_object_rect;

            GameObject game_object = value.GetGameObject();
            Type component_type = value.GetComponentType();

            rect.SplitByXLeftPercent(0.3f, out game_object_rect, out rect);

            game_object = (GameObject)EditorGUI.ObjectField(
                game_object_rect,
                game_object,
                typeof(GameObject),
                true
            );

            if (game_object != null)
            {
                component_type = EditorGUIExtensions.Popup(
                    rect,
                    component_type,
                    game_object.GetAllComponents()
                        .Convert(c => c.GetType())
                        .Unique()
                );
            }
            else
            {
                GUI.Label(rect, "No GameObject Selected");
            }

            return new TargetComponent(game_object, component_type);
        }

        public EditorGUIElement_EditPropertyValue_TargetComponent(EditProperty_Value p) : base(p) { }
    }
}