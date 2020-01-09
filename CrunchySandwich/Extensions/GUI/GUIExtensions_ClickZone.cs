using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public bool ClickZone(Rect rect)
        {
            GUIControlHandle handle = GetControlHandle(FocusType.Passive);

            switch (handle.GetEventType())
            {
                case EventType.MouseDown:
                    if (rect.Contains(handle.GetEvent().mousePosition))
                        handle.CaptureControl();

                    break;

                case EventType.MouseUp:
                    if (handle.ReleaseControl() && rect.Contains(handle.GetEvent().mousePosition))
                    {
                        handle.UseEvent();
                        return true;
                    }

                    break;
            }

            return false;
        }
    }
}