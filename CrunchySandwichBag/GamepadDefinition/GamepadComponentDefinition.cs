using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bread;
    using Ginger;
    using Sandwich;

    [Serializable]
    public class GamepadComponentDefinition
    {
        [SerializeField]private string name;
        [SerializeField]private GamepadComponentType component_type;

        private CSTextDocumentWriter CreateWriter(CSTextDocumentBuilder builder)
        {
            return builder.CreateWriterWithVariablePairs(
                "TYPE", component_type.GetSystemType().Name,
                "GET_FUNCTION", ("Get_" + name).StyleAsFunctionName(),
                "VARIABLE", name.StyleAsVariableName(),
                "ENUM", name.StyleAsEnumName(),
                "ENUM_VALUE", name.StyleAsEnumName().StyleAsDoubleQuoteLiteral()
            );
        }

        public void GenerateGetComponentFunction(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = CreateWriter(builder);

            writer.Write("public ?TYPE ?GET_FUNCTION()", delegate() {
                writer.Write("return ?VARIABLE;");
            });
        }

        public void GenerateIdMember(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = CreateWriter(builder);

            writer.Write("public readonly ?ENUM = new ?TYPE(?ENUM_VALUE);");
        }

        public void GenerateIdYield(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = CreateWriter(builder);

            writer.Write("yield return ?ENUM;");
        }

        public string GetName()
        {
            return name;
        }

        public GamepadComponentType GetComponentType()
        {
            return component_type;
        }
    }
}