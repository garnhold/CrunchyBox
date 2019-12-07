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

        [SerializeField]private bool use_open_tk;

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
                "INVERT_HORIZONTAL", invert_horizontal.ToString().StyleAsLiteralBool(),
                "INVERT_VERTICAL", invert_vertical.ToString().StyleAsLiteralBool(),
                "DEVICE_ID", device_id,
                "HORIZONTAL_AXIS_INDEX", horizontal_axis_index.ToString(),
                "VERTICAL_AXIS_INDEX", vertical_axis_index.ToString()
            );

            if(use_open_tk)
                writer.Write("?VARIABLE = new InputDeviceComponent_Stick(new InputDeviceRawStick_Axises(new InputDeviceRawAxis_Filtered_OpenTK(?DEVICE_ID, ?HORIZONTAL_AXIS_INDEX, AxisFilters.General(?DEAD_ZONE, ?INVERT_HORIZONTAL)), new InputDeviceRawAxis_Filtered_OpenTK(?DEVICE_ID, ?VERTICAL_AXIS_INDEX, AxisFilters.General(?DEAD_ZONE, ?INVERT_VERTICAL))));");
            else
                writer.Write("?VARIABLE = new InputDeviceComponent_Stick(new InputDeviceRawStick_Axises(new InputDeviceRawAxis_Filtered_Unity(?INTERNAL_HORIZONTAL_AXIS_NAME + ?DEVICE_ID, ?DEAD_ZONE), new InputDeviceRawAxis_Filtered_Unity(?INTERNAL_VERTICAL_AXIS_NAME + ?DEVICE_ID, ?DEAD_ZONE)));");

        }
    }
}