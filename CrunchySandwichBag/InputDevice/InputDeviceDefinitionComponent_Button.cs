﻿using System;
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
    public abstract class InputDeviceDefinitionComponent_Button : InputDeviceDefinitionComponent
    {
        public override void GenerateClassMembers(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "GET_FUNCTION", ("Get_" + GetName()).StyleAsFunctionName()
            );

            writer.Write("private InputDeviceComponent_Button ?VARIABLE;");
            writer.Write("public InputDeviceComponent_Button ?GET_FUNCTION()", delegate() {
                writer.Write("return ?VARIABLE;");
            });
        }
    }
}