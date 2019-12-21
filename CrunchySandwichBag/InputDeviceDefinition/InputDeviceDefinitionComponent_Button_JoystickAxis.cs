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
    
    public class InputDeviceDefinitionComponent_Button_JoystickAxis : InputDeviceDefinitionComponent_Button
    {
        [SerializeField]private int axis_index;

        [SerializeField]private float down_value;
        [SerializeField]private float down_tolerance;

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_index_variable)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),

                "DEVICE_INDEX", device_index_variable,
                "AXIS_INDEX", axis_index.StyleAsLiteral(),

                "DOWN_VALUE", down_value.StyleAsLiteral(),
                "DOWN_TOLERANCE", down_tolerance.StyleAsLiteral()
            );

            writer.Write(@"?VARIABLE = new InputDeviceComponent_Button(
                new InputDeviceRawButton_Axis(
                    new InputDeviceRawAxis_OpenTKJoystickAxis(?DEVICE_INDEX, ?AXIS_INDEX),
                    ?DOWN_VALUE,
                    ?DOWN_TOLERANCE
                )
            );");
        }
    }
}