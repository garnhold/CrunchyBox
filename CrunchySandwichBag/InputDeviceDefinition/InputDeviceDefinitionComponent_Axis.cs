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
    
    public abstract class InputDeviceDefinitionComponent_Axis : InputDeviceDefinitionComponent
    {
        public override void GenerateClassMembers(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "GET_FUNCTION", ("Get_" + GetName()).StyleAsFunctionName()
            );

            writer.Write("private InputDeviceComponent_Axis ?VARIABLE;");
            writer.Write("public InputDeviceComponent_Axis ?GET_FUNCTION()", delegate() {
                writer.Write("return ?VARIABLE;");
            });
        }
    }
}