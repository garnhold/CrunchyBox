using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(TargetMethod), true)]
    public class EditorGUIElement_EditPropertyValue_TargetMethod : EditorGUIElement_EditPropertyValue<TargetMethod>
    {
        protected override TargetMethod DrawValueInternal(Rect rect, TargetMethod value)
        {
            Rect game_object_rect;
            Rect method_rect;

            GameObject game_object = value.GetGameObject();
            Type component_type = value.GetComponentType();
            MethodInfo method = value.GetMethod();

            rect.SplitByYBottomOffset(LINE_HEIGHT, out rect, out method_rect);
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

            if (component_type != null)
            {
                method = EditorGUIExtensions.Popup(
                    method_rect,
                    method,
                    component_type.GetFilteredInstanceMethods(
                        Filterer_MethodInfo.IsPublicMethod()
                    ).Convert<MethodInfoEX, MethodInfo>()
                );
            }
            else
            {
                GUI.Label(method_rect, "No Component Selected");
            }

            return new TargetMethod(
                new TargetComponent(game_object, component_type),
                method
            );
        }

        protected override float CalculateElementHeightInternal()
        {
            return LINE_HEIGHT * 2.0f;
        }

        public EditorGUIElement_EditPropertyValue_TargetMethod(EditProperty_Value p) : base(p) { }
    }
}