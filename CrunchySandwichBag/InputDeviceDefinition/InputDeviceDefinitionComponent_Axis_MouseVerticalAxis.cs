using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Ginger;
    using Sandwich;
    
    public class InputDeviceDefinitionComponent_Axis_MouseVerticalAxis : InputDeviceDefinitionComponent_Axis
    {
        [SerializeField]private bool invert;

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_variable)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),

                "DEVICE_INDEX", device_variable,
                "INVERT", invert.ToString().StyleAsLiteralBool()
            );

            writer.Write(@"?VARIABLE = new InputDeviceComponent_Axis(
                new InputDeviceRawAxis_Filtered(
                    new InputDeviceRawAxis_MouseVerticalAxis(?DEVICE_INDEX, ?AXIS_INDEX)
                    AxisFilters.General(0.0f, ?INVERT)
                )
            );");
        }
    }
}