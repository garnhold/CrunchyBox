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
    public class InputDeviceDefinitionComponent_Axis_Joystick : InputDeviceDefinitionComponent_Axis
    {
        [SerializeField]private int axis_id;

        [SerializeField]private bool invert;
        [SerializeField]private bool snap;

        [SerializeField]private float gravity;
        [SerializeField]private float dead;
        [SerializeField]private float sensitivity;

        public override void GenerateInternalAxises(int device_id, SerializedProperty axises)
        {
            PushInternalJoystickAxis(axises.PushArrayElement(), GetName(), device_id, axis_id, invert, snap, gravity, dead, sensitivity);
        }

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_id)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "INTERNAL_AXIS_NAME", GetName().StyleAsLiteralString(),
                "DEVICE_ID", device_id
            );

            writer.Write("?VARIABLE = new InputDeviceComponent_Axis_Basic(?INTERNAL_AXIS_NAME + ?DEVICE_ID);");
        }
    }
}