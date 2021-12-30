using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public Vector2 XYControl(Rect rect, Vector2 value, FloatRange x_range, FloatRange y_range)
        {
            GUIControlHandle handle = GUIExtensions.GetControlHandle(FocusType.Passive);

            Vector2 mouse_point = handle.GetEvent().mousePosition;

            FloatRange interface_x_range = rect.GetHorizontalRange();
            FloatRange interface_y_range = rect.GetVerticalRange().GetFlipped();

            Vector2 point = new Vector2(
                value.x.ConvertFromRangeToRange(x_range, interface_x_range),
                value.y.ConvertFromRangeToRange(y_range, interface_y_range)
            );

            GUIExtensions.DrawPoint(
                point,
                4.0f,
                Color.red
            );

            if (rect.Contains(mouse_point))
            {
                if (handle.GetEventType().IsMouseDownish())
                {
                    return new Vector2(
                        mouse_point.x.ConvertFromRangeToRange(interface_x_range, x_range),
                        mouse_point.y.ConvertFromRangeToRange(interface_y_range, y_range)
                    );
                }
            }

            return value;
        }
        static public Vector2 XYControl(Rect rect, Vector2 value, FloatRange range)
        {
            return EditorGUIExtensions.XYControl(rect, value, range, range);
        }
    }
}