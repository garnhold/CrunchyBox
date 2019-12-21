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

    public abstract class InputDeviceDefinitionComponent
    {
        [SerializeField] private string name;

        public abstract void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_index_variable);
        public abstract void GenerateClassMembers(CSTextDocumentBuilder builder);

        public string GetName()
        {
            return name;
        }

        public void GenerateIdsMember(CSTextDocumentBuilder builder, string id_type)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "TYPE", id_type,
                "NAME", GetName().StyleAsEnumName(),
                "VALUE", GetName().StyleAsDoubleQuoteLiteral()
            );

            writer.Write("static public readonly ?TYPE ?NAME = new ?TYPE(?VALUE);");
        }

        public void GenerateIdsYield(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "NAME", GetName().StyleAsEnumName()
            );

            writer.Write("yield return ?NAME;");
        }

        public void GenerateGetVariableCase(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "VALUE", GetName().StyleAsDoubleQuoteLiteral()
            );

            writer.Write("case ?VALUE: return ?VARIABLE;");
        }

        public void GenerateClassUpdate(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName()
            );

            writer.Write("?VARIABLE.Update();");
        }
    }
}