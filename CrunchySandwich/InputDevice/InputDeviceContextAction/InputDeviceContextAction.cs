using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceContextAction<ALL, AXIS, BUTTON, STICK>
    {
        private InputDeviceAction<ALL, AXIS, BUTTON, STICK> action;
        private Process process;

        private GameObject indicator;

        private InputDevice<ALL, AXIS, BUTTON, STICK> device;

        public InputDeviceContextAction(InputDeviceAction<ALL, AXIS, BUTTON, STICK> a, Process p, InputDevice<ALL, AXIS, BUTTON, STICK> d)
        {
            action = a;
            process = p;

            indicator = action.SpawnIndicator();

            device = d;
        }

        public void Update()
        {
            if (action.IsOccuringThisFrame(device))
                Force();
        }

        public void Force()
        {
            if (process != null)
                process();
        }

        public void Release()
        {
            indicator.IfNotNull(i => i.Destroy());
        }
    }
}