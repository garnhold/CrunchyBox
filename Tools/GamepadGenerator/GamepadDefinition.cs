using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Recipe;
using Crunchy.Ginger;
using Crunchy.Bread;

public class GamepadDefinition
{
    [TyonField]private int max_number_devices;
    [TyonField]private List<GamepadComponentDefinition> components;

    private void GenerateSatelliteClass(CSTextDocumentBuilder builder)
    {
        CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
        );

        writer.Write("[ApplicationEXSatellite]");
        writer.Write("static public class GamepadSatellite", delegate() {
            writer.Write("static private void Update()", delegate() {
                writer.Write("Gamepad.GetGamepads().Process(d => d.Update());");
            });
        });
    }

    private void GenerateClass(CSTextDocumentBuilder builder)
    {
        CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
        );

        writer.Write("public partial class Gamepad : GamepadBase", delegate() {
            writer.Write("private readonly int gamepad_index;");

            components.Process(c => c.GenerateClassMember(builder));

            for (int i = 0; i < max_number_devices; i++)
                writer.Write("static public readonly Gamepad Gamepad" + i + " = new Gamepad(" + i + ");");

            writer.Write("static public Gamepad GetGamepad(int gamepad_index)", delegate() {
                writer.Write("switch(gamepad_index)", delegate() {
                    for (int i = 0; i < max_number_devices; i++)
                        writer.Write("case " + i + ": return Gamepad" + i + ";");
                });

                writer.Write("throw new UnaccountedBranchException(\"gamepad_index\", gamepad_index);");
            });

            writer.Write("static public IEnumerable<Gamepad> GetGamepads()", delegate() {
                for (int i = 0; i < max_number_devices; i++)
                    writer.Write("yield return Gamepad" + i + ";");
            });

            writer.Write("private Gamepad(int index)", delegate() {
                writer.Write("gamepad_index = index;");

                components.Process(c => c.GenerateConstructor(builder));

                writer.Write("Construct(gamepad_index);");
            });

            components.Process(d => d.GenerateGetComponentFunction(builder));

            writer.Write("public int GetGamepadIndex()", delegate() {
                writer.Write("return gamepad_index;");
            });
        });
    }

    private void GenerateInputDeviceIds(CSTextDocumentBuilder builder, GamepadComponentType type)
    {
        CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
            "CLASS", "Gamepad" + type + "Ids",
            "TYPE", "Gamepad" + type + "Id"
        );

        writer.Write("static public class ?CLASS", delegate() {
            components.Narrow(c => c.GetComponentType() == type)
                .Process(c => c.GenerateIdMember(builder));

            writer.Write("static public IEnumerable<?TYPE> GetAll()", delegate() {
                components.Narrow(c => c.GetComponentType() == type)
                    .Process(c => c.GenerateIdYield(builder));

                writer.Write("yield break;");
            });
        });
    }

    public void GenerateCode(string filename)
    {
        CSTextDocument document = new CSTextDocument(new CSHeader_SimpleDated("MMMM dd, yyyy"));

        CSTextDocumentBuilder builder = document.CreateCSTextBuilder();
        CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs();

        writer.Write("using System;");
        writer.Write("using System.Collections;");
        writer.Write("using System.Collections.Generic;");

        writer.Write("using Crunchy.Dough;");
        writer.Write("using Crunchy.Salt;");
        writer.Write("using Crunchy.Noodle;");
        writer.Write("using Crunchy.Bread;");
        writer.Write("using Crunchy.Sandwich;");

        GenerateSatelliteClass(builder);

        typeof(GamepadComponentType).GetEnumValues<GamepadComponentType>()
            .Process(t => GenerateInputDeviceIds(builder, t));

        GenerateClass(builder);

        document.RenderDocument().Save(filename, true);
    }
}