using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class GUIControl_MouseCapture : GUIControl
    {
        public GUIControl_MouseCapture() : base(FocusType.Passive) { }

        public void Update(Rect rect, TryProcess<EventType, Event> process)
        {
            base.Update(delegate(EventType type, Event evt) {
                switch (type)
                {
                    case EventType.MouseDown:
                        if (rect.Contains(evt.mousePosition))
                            CaptureControl();

                        break;

                    case EventType.MouseUp:
                        ReleaseControl();
                        break;
                }

                if (evt.isMouse && IsControlCaptured())
                    return process(type, evt);

                return false;
            });
        }

        public void UpdateClick(Rect rect, Process process)
        {
            Update(rect, delegate(EventType type, Event evt) {
                if (evt.type == EventType.MouseUp)
                {
                    process();
                    return true;
                }

                return false;
            });
        }
        public bool UpdateClick(Rect rect)
        {
            bool state = false;

            UpdateClick(rect, delegate() {
                state = true;
            });

            return state;
        }

        public void UpdatePoint(Rect rect, Process<int, Vector2> process)
        {
            Update(rect, delegate(EventType type, Event evt) {
                process(
                    evt.button,
                    (evt.mousePosition - rect.min).BindBetween(Vector2.zero, rect.GetSize())
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