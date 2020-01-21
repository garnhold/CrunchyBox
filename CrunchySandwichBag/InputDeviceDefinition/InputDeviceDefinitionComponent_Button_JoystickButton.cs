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
    
    public class InputDeviceDefinitionComponent_Button_JoystickButton : InputDeviceDefinitionComponent_Button
    {
        [SerializeField] private int button_index;

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_index_variable)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),

                "DEVICE_INDEX", device_index_variable,
                "BUTTON_INDEX", button_index.StyleAsLiteral()
            );

            writer.Write(@"?VARIABLE = new InputDeviceComponent_Button(
                new InputDeviceRawButton_JoystickButton(?DEVICE_INDEX, ?BUTTON_INDEX)
            );");
        }
    }
}