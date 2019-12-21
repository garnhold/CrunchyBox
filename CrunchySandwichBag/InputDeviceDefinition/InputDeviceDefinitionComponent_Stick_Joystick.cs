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
    
    public class InputDeviceDefinitionComponent_Stick_Joystick : InputDeviceDefinitionComponent_Stick
    {
        [SerializeField]private int horizontal_axis_index;
        [SerializeField]private int vertical_axis_index;

        [SerializeField] private float dead;
        [SerializeField]private bool invert_horizontal;
        [SerializeField]private bool invert_vertical;

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_index_variable)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),

                "DEVICE_INDEX", device_index_variable,
                "HORIZONTAL_AXIS_INDEX", horizontal_axis_index.StyleAsLiteral(),
                "VERTICAL_AXIS_INDEX", vertical_axis_index.StyleAsLiteral(),

                "DEAD_ZONE", dead.StyleAsLiteral(),
                "INVERT_HORIZONTAL", invert_horizontal.ToString().StyleAsLiteralBool(),
                "INVERT_VERTICAL", invert_vertical.ToString().StyleAsLiteralBool()
            );

            writer.Write(@"?VARIABLE = new InputDeviceComponent_Stick(
                new InputDeviceRawStick_Axises(
                    new InputDeviceRawAxis_Filtered(
                        new InputDeviceRawAxis_OpenTKJoystickAxis(?DEVICE_INDEX, ?HORIZONTAL_AXIS_INDEX),
                        AxisFilters.General(?DEAD_ZONE, ?INVERT_HORIZONTAL)
                    ),
                    new InputDeviceRawAxis_Filtered(
                        new InputDeviceRawAxis_OpenTKJoystickAxis(?DEVICE_INDEX, ?VERTICAL_AXIS_INDEX),
                        AxisFilters.General(?DEAD_ZONE, ?INVERT_VERTICAL)
                    )
                )
            );");
        }
    }
}