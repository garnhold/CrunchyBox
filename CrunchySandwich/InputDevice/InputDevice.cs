using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceBase
    {
        private Vector3 abstract_position;

        public abstract void Update();

        public abstract InputDeviceComponent GetComponent(InputDeviceComponentId component);
        public abstract InputDeviceComponent_Axis GetAxis(InputDeviceAxisId axis);
        public abstract InputDeviceComponent_Button GetButton(InputDeviceButtonId button);
        public abstract InputDeviceComponent_Stick GetStick(InputDeviceStickId stick);

        public void SetAbstractPosition(Vector3 position)
        {
            abstract_position = position;
        }

        public Vector3 GetAbstractPosition()
        {
            return abstract_position;
        }
    }
}