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
    public class InputDeviceDefinitionComponent_Button_JoystickAxis : InputDeviceDefinitionComponent_Button
    {
        [SerializeField]private int axis_id;

        [SerializeField]private float down_value;
        [SerializeField]private float down_tolerance;

        public override void GenerateInternalAxises(int device_id, SerializedProperty axises)
        {
            PushInternalJoystickAxis(axises.PushArrayElement(), GetName(), device_id, axis_id);
        }

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_id)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "INTERNAL_AXIS_NAME", GetName().StyleAsLiteralString(),
                "DEVICE_ID", device_id,
                "DOWN_VALUE", down_value + "f",
                "DOWN_TOLERANCE", down_tolerance + "f"
            );

            writer.Write("?VARIABLE = new InputDeviceComponent_Button_AxisZone(?INTERNAL_AXIS_NAME + ?DEVICE_ID, ?DOWN_VALUE, ?DOWN_TOLERANCE);");
        }
    }
}