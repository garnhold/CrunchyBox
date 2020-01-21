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
    
    public class InputDeviceDefinitionComponent_Axis_JoystickAxis : InputDeviceDefinitionComponent_Axis
    {
        [SerializeField]private int axis_id;

        [SerializeField] private float dead;
        [SerializeField]private bool invert;

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_variable)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),

                "DEVICE_INDEX", device_variable,
                "AXIS_INDEX", axis_id.StyleAsLiteral(),

                "DEAD_ZONE", dead.ToString().StyleAsLiteralFloat(),
                "INVERT", invert.ToString().StyleAsLiteralBool()
            );

            writer.Write(@"?VARIABLE = new InputDeviceComponent_Axis(
                new InputDeviceRawAxis_Filtered(
                    new InputDeviceRawAxis_JoystickAxis(?DEVICE_INDEX, ?AXIS_INDEX)
                    AxisFilters.General(?DEAD_ZONE, ?INVERT)
                )
            );");
        }
    }
}