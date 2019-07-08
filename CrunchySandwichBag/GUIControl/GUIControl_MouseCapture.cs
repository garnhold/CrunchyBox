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
    public class GUIControl_MouseCapture : GUIControl
    {
        public GUIControl_MouseCapture() : base(FocusType.Passive) { }

        public void Update(Rect rect, TryProcess<EventType, Event> process)
        {
            base.Update(delegate(EventType type, Event vnt) {
                switch (type)
                {
                    case EventType.MouseDown:
                        if (rect.Contains(vnt.mousePosition))
                            CaptureControl();

                        break;

                    case EventType.MouseUp:
                        ReleaseControl();
                        break;
                }

                if (vnt.isMouse && IsControlCaptured())
                    return process(type, vnt);

                return false;
            });
        }

        public void UpdatePoint(Rect rect, Process<int, Vector2> process)
        {
            Update(rect, delegate(EventType type, Event vnt) {
                process(
                    vnt.button,
                    (vnt.mousePosition - rect.min).BindBetween(Vector2.zero, rect.GetSize())
                );
                return true;
            });
        }

        public void UpdatePercentPoint(Rect rect, Process<int, Vector2> process)
        {
            UpdatePoint(rect, delegate(int button, Vector2 point) {
                process(button, point.GetComponentDivide(rect.GetSize()));
            });
        }
    }
}