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
    
    [AssetClassCategory("Input")]
    public class GamepadDefinition : CustomAsset
    {
        [SerializeField]private int max_number_devices;
        [SerializeField]private List<GamepadComponentDefinition> components;

        [ContextMenu("Use")]
        private void Use()
        {
            CodeGenerator.GenerateCode("Gamepad", b => GenerateCode(b), GeneratedCodeType.RuntimeDefinition);
        }

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
                writer.Write("private readonly int device_index;");

                for (int i = 0; i < max_number_devices; i++)
                    writer.Write("static public readonly Gamepad Gamepad" + i + " = new Gamepad(" + i + ");");

                writer.Write("static public Gamepad GetGamepad(int device_index)", delegate() {
                    writer.Write("switch(device_index)", delegate() {
                        for (int i = 0; i < max_number_devices; i++)
                            writer.Write("case " + i + ": return Gamepad" + i + ";");
                    });

                    writer.Write("throw new UnaccountedBranchException(\"device_index\", device_index);");
                });

                writer.Write("static public IEnumerable<Gamepad> GetGamepads()", delegate() {
                    for (int i = 0; i < max_number_devices; i++)
                        writer.Write("yield return Gamepad" + i + ";");
                });

                writer.Write("private Gamepad(int index)", delegate() {
                    writer.Write("device_index = index;");

                    writer.Write("Construct();");
                });

                components.Process(d => d.GenerateGetComponentFunction(builder));

                writer.Write("public int GetDeviceId()", delegate() {
                    writer.Write("return device_index;");
                });
            });
        }

        private void GenerateInputDeviceIds(CSTextDocumentBuilder builder, GamepadComponentType type)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "CLASS", type.GetSystemType().GetBasicName() + "s",
                "TYPE", type.GetSystemType().GetBasicName()
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

        public void GenerateCode(CSTextDocumentBuilder builder)
        {
            GenerateSatelliteClass(builder);

            typeof(GamepadComponentType).GetEnumValues<GamepadComponentType>()
                .Process(t => GenerateInputDeviceIds(builder, t));

            GenerateClass(builder);
        }
    }
}