using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public bool MouseArea(Rect rect, out Vector2 position, bool should_confine_position, bool should_position_be_relative)
        {
            GUIControlHandle handle = GetControlHandle(FocusType.Passive);

            switch (handle.GetEventType())
            {
                case EventType.MouseDown:
                    if (rect.Contains(handle.GetEvent().mousePosition))
                        handle.CaptureControl();

                    break;

                case EventType.MouseUp:
                    handle.ReleaseControl();
                    break;
            }

            if (handle.IsControlCaptured() && handle.GetEventType().IsMouseRelated())
            {
                position = handle.GetEvent().mousePosition;

                if (should_confine_position)
                    position = position.BindWithin(rect);

                if (should_position_be_relative)
                    position = position - rect.min;

                return true;
            }

            position = new Vector2();
            return false;
        }
        static public bool MousePercentArea(Rect rect, out Vector2 percent, bool should_confine_position, bool should_position_be_relative)
        {
            Vector2 position;
            bool to_return = MouseArea(rect, out position, should_confine_position, should_position_be_relative);

            percent = position.GetComponentDivide(rect.GetSize());
            return to_return;
        }
    }
}