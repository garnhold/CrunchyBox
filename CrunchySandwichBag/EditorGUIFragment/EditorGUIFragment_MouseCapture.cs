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
    public abstract class EditorGUIFragment_MouseCapture : EditorGUIFragment
    {
        protected abstract void HandleMouseEvent(Rect rect, EventType type, Event vnt);

        protected override bool HandleEvent(Rect rect, EventType type, Event vnt)
        {
            switch (type)
            {
                case EventType.MouseDown:
                    if(rect.Contains(vnt.mousePosition))
                        CaptureControl();

                    break;

                case EventType.MouseUp:
                    ReleaseControl();
                    break;
            }

            if (vnt.isMouse && IsControlCaptured())
            {
                HandleMouseEvent(rect, type, vnt);
                return true;
            }

            return false;
        }
    }
}