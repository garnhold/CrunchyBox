using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    
    public struct GUIControlHandle
    {
        private int control_id;

        public GUIControlHandle(FocusType f)
        {
            control_id = GUIUtility.GetControlID(f);
        }

        public void UseEvent()
        {
            GetEvent().Use();
            GUI.changed = true;
        }

        public void CaptureControl()
        {
            GUIUtility.hotControl = control_id;
        }

        public bool ReleaseControl()
        {
            if (IsControlCaptured())
            {
                GUIUtility.hotControl = 0;
                return true;
            }

            return false;
        }

        public bool IsControlCaptured()
        {
            if (GUIUtility.hotControl == control_id)
                return true;

            return false;
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