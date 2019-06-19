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
    public class InputDeviceDefinitionComponent_Button_Basic : InputDeviceDefinitionComponent_Button
    {
        [SerializeField]private string button_pattern;

        public override void GenerateInternalAxises(int device_id, SerializedProperty axises)
        {
            PushInternalButton(axises.PushArrayElement(), GetName(), device_id, button_pattern.RegexReplace("\\#", device_id.ToString()));
        }

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_id)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "INTERNAL_AXIS_NAME", GetName().StyleAsLiteralString(),
                "DEVICE_ID", device_id
            );

            writer.Write("?VARIABLE = new InputDeviceComponent_Button(?INTERNAL_AXIS_NAME + ?DEVICE_ID);");
        }
    }
}