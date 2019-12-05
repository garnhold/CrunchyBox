using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class InputDeviceDefinitionComponent_Stick_Joystick : InputDeviceDefinitionComponent_Stick
    {
        [SerializeField]private int horizontal_axis_index;
        [SerializeField]private int vertical_axis_index;

        [SerializeField]private bool invert_horizontal;
        [SerializeField]private bool invert_vertical;
        [SerializeField]private bool snap;

        [SerializeField]private float gravity;
        [SerializeField]private float dead;
        [SerializeField]private float sensitivity;

        public override void GenerateInternalAxises(int device_id, SerializedProperty axises)
        {
            PushInternalJoystickAxis(axises.PushArrayElement(), GetName() + "Horizontal", device_id, horizontal_axis_index, invert_horizontal, snap, gravity, dead, sensitivity);
            PushInternalJoystickAxis(axises.PushArrayElement(), GetName() + "Vertical", device_id, vertical_axis_index, invert_vertical, snap, gravity, dead, sensitivity);
        }

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_id)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "INTERNAL_HORIZONTAL_AXIS_NAME", (GetName() + "Horizontal").StyleAsLiteralString(),
                "INTERNAL_VERTICAL_AXIS_NAME", (GetName() + "Vertical").StyleAsLiteralString(),
                "DEAD_ZONE", dead.ToString().StyleAsLiteralFloat(),
                "DEVICE_ID", device_id
            );

            writer.Write("?VARIABLE = new InputDeviceComponent_Stick(new InputDeviceRawStick_Axises(new InputDeviceRawAxis_Native(?INTERNAL_HORIZONTAL_AXIS_NAME + ?DEVICE_ID), new InputDeviceRawAxis_Native(?INTERNAL_VERTICAL_AXIS_NAME + ?DEVICE_ID, ?DEAD_ZONE)));");
        }
    }
}