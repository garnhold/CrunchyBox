using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class GUIControl
    {
        private int control_id;
        private FocusType focus_type;

        private bool is_control_captured;

        public GUIControl(FocusType f)
        {
            focus_type = f;
        }

        public void Update()
        {
            control_id = GUIUtility.GetControlID(focus_type);
            if (is_control_captured)
                GUIUtility.hotControl = control_id;
        }
        public void Update(TryProcess<EventType, Event> operation)
        {
            Update();
            if (operation(GetEventType(), GetEvent()))
                UseEvent();
        }

        public void UseEvent()
        {
            GetEvent().Use();
            GUI.changed = true;
        }

        public void ReleaseControl()
        {
            if (is_control_captured)
            {
                GUIUtility.hotControl = 0;
                is_control_captured = false;
            }
        }

        public void CaptureControl()
        {
            GUIUtility.hotControl = control_id;
            is_control_captured = true;
        }

        public bool IsControlCaptured()
        {
            return is_control_captured;
        }

        public EventType GetEventType()
        {
            return Event.current.GetTypeForControl(control_id);
        }

        public Event GetEvent()
        {
            return Event.current;
        }
    }
}