using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Recipe;
using Crunchy.Ginger;
using Crunchy.Bread;

public class GamepadComponentDefinition
{
    [TyonField]private string name;
    [TyonField]private InputAtomLockType lock_type;
    [TyonField]private GamepadComponentType component_type;

    private CSTextDocumentWriter CreateWriter(CSTextDocumentBuilder builder)
    {
        return builder.CreateWriterWithVariablePairs(
            "TYPE", component_type.GetSystemType().Name,
            "ENUM_TYPE", "Gamepad" + component_type.GetEnumName() + "Id",
            "ENUM_TYPES", "Gamepad" + component_type.GetEnumName() + "Ids",
            "GET_FUNCTION", ("Get_" + name).StyleAsFunctionName(),
            "CREATE_FUNCTION", "Create" + component_type.GetEnumName(),
            "VARIABLE", name.StyleAsVariableName(),
            "ENUM", name.StyleAsEnumName(),
            "ENUM_VALUE", name.StyleAsEnumName().StyleAsDoubleQuoteLiteral(),
            "LOCK_TYPE", lock_type.StyleAsLiteral()
        );
    }

    public void GenerateClassMember(CSTextDocumentBuilder builder)
    {
        CSTextDocumentWriter writer = CreateWriter(builder);

        writer.Write("private ?TYPE ?VARIABLE;");
    }

    public void GenerateConstructor(CSTextDocumentBuilder builder)
    {
        CSTextDocumentWriter writer = CreateWriter(builder);

        writer.Write("?VARIABLE = ?CREATE_FUNCTION(?ENUM_TYPES.?ENUM, ?LOCK_TYPE);");
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

        writer.Write("static public readonly ?ENUM_TYPE ?ENUM = new ?ENUM_TYPE(?ENUM_VALUE);");
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