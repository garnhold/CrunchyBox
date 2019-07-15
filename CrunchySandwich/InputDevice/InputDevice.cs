using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDevice<ALL, AXIS, BUTTON, STICK>
    {
        private InputDeviceContextAction<ALL, AXIS, BUTTON, STICK> context_action;

        protected abstract void UpdateInternal();

        public abstract InputDeviceComponent GetComponent(ALL all);
        public abstract InputDeviceComponent_Axis GetAxis(AXIS axis);
        public abstract InputDeviceComponent_Button GetButton(BUTTON button);
        public abstract InputDeviceComponent_Stick GetStick(STICK stick);

        public void Update()
        {
            UpdateInternal();

            context_action.IfNotNull(a => a.Update());
        }

        public void PushContextAction(InputDeviceAction<ALL, AXIS, BUTTON, STICK> action, Process process)
        {
            context_action.IfNotNull(a => a.Release());

            context_action = new InputDeviceContextAction<ALL, AXIS, BUTTON, STICK>(
                action, process, this
            );
        }
    }
}