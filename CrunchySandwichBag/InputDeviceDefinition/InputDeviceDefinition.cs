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
    using Ginger;
    using Sandwich;
    
    [AssetClassCategory("Input")]
    public class InputDeviceDefinition : CustomAsset
    {
        [SerializeField]private int max_number_devices;
        [SerializeFieldEX][PolymorphicField]private List<InputDeviceDefinitionComponent> components;

        [ContextMenu("Use")]
        private void Use()
        {
            CodeGenerator.GenerateCode("InputDevice", b => GenerateCode(b), GeneratedCodeType.RuntimeDefinition);
        }

        private void GenerateSatelliteClass(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
            );

            writer.Write("[ApplicationEXSatellite]");
            writer.Write("static public class InputDeviceSatellite", delegate() {
                writer.Write("static private void Update()", delegate() {
                    writer.Write("InputDevice.GetInputDevices().Process(d => d.Update());");
                });
            });
        }

        private void GenerateClass(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
            );

            writer.Write("public class InputDevice : InputDeviceBase", delegate() {
                writer.Write("private readonly int device_index;");

                for (int i = 0; i < max_number_devices; i++)
                    writer.Write("static public readonly InputDevice Device" + i + " = new InputDevice(" + i + ");");

                writer.Write("static public InputDevice GetInputDevice(int device_index)", delegate() {
                    writer.Write("switch(device_index)", delegate() {
                        for (int i = 0; i < max_number_devices; i++)
                            writer.Write("case " + i + ": return Device" + i + ";");
                    });

                    writer.Write("throw new UnaccountedBranchException(\"device_index\", device_index);");
                });

                writer.Write("static public IEnumerable<InputDevice> GetInputDevices()", delegate() {
                    for (int i = 0; i < max_number_devices; i++)
                        writer.Write("yield return Device" + i + ";");
                });

                writer.Write("private InputDevice(int index)", delegate() {
                    writer.Write("device_index = index;");

                    components.Process(c => c.GenerateClassConstructor(builder, "device_index"));
                });

                writer.Write("public override void Update()", delegate() {
                    components.Process(c => c.GenerateClassUpdate(builder));
                });

                GenerateGetComponentAllFunction(builder);
                GenerateGetComponentFunction<InputDeviceDefinitionComponent_Axis>(builder);
                GenerateGetComponentFunction<InputDeviceDefinitionComponent_Button>(builder);
                GenerateGetComponentFunction<InputDeviceDefinitionComponent_Stick>(builder);

                components.Process(c => c.GenerateClassMembers(builder));

                writer.Write("public int GetDeviceId()", delegate() {
                    writer.Write("return device_index;");
                });
            });
        }

        private void GenerateGetComponentAllFunction(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
            );

            writer.Write("public override InputDeviceComponent GetComponent(InputDeviceComponentId value)", delegate() {
                writer.Write("switch(value.GetValue())", delegate() {
                    components.Process(c => c.GenerateGetVariableCase(builder));
                });

                writer.Write("throw new UnaccountedBranchException(\"value\", value);");
            });
        }

        private void GenerateGetComponentFunction<T>(CSTextDocumentBuilder builder) where T : InputDeviceDefinitionComponent
        {
            string name = typeof(T).Name.TrimPrefix("InputDeviceDefinitionComponent_");
            string id_type = ("InputDevice_" + name + "_Id").StyleAsClassName();

            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "ID_TYPE", id_type,
                "TYPE", "InputDeviceComponent_" + name.StyleAsClassName(),
                "FUNCTION", ("Get_" + name).StyleAsFunctionName()
            );

            writer.Write("public override ?TYPE ?FUNCTION(?ID_TYPE value)", delegate() {
                writer.Write("switch(value.GetValue())", delegate() {
                    components.Convert<InputDeviceDefinitionComponent, T>().Process(c => c.GenerateGetVariableCase(builder));
                });

                writer.Write("throw new UnaccountedBranchException(\"value\", value);");
            });
        }

        private void GenerateInputDeviceIds<T>(CSTextDocumentBuilder builder, string type) where T : InputDeviceDefinitionComponent
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "CLASS", type + "s",
                "TYPE", type
            );

            writer.Write("static public class ?CLASS", delegate() {
                components.Convert<InputDeviceDefinitionComponent, T>().Process(c => c.GenerateIdsMember(builder, type));

                writer.Write("static public IEnumerable<?TYPE> GetAll()", delegate() {
                    components.Convert<InputDeviceDefinitionComponent, T>().Process(c => c.GenerateIdsYield(builder));

                    writer.Write("yield break;");
                });
            });
        }

        public void GenerateCode(CSTextDocumentBuilder builder)
        {
            GenerateSatelliteClass(builder);

            GenerateInputDeviceIds<InputDeviceDefinitionComponent>(builder, "InputDeviceComponentId");
            GenerateInputDeviceIds<InputDeviceDefinitionComponent_Axis>(builder, "InputDeviceAxisId");
            GenerateInputDeviceIds<InputDeviceDefinitionComponent_Button>(builder, "InputDeviceButtonId");
            GenerateInputDeviceIds<InputDeviceDefinitionComponent_Stick>(builder, "InputDeviceStickId");

            GenerateClass(builder);
        }
    }
}