﻿using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Ginger;
    using Sandwich;
    
    public class InputDeviceDefinitionComponent_Button_KeyboardButton : InputDeviceDefinitionComponent_Button
    {
        [SerializeField] private Key key;

        public override void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_index_variable)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),

                "DEVICE_INDEX", device_index_variable,
                "KEY", key.StyleAsLiteral()
            );

            writer.Write(@"?VARIABLE = new InputDeviceComponent_Button(
                new InputDeviceRawButton_KeyboardButton(?DEVICE_INDEX, ?KEY)
            );");
        }
    }
}