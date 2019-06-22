using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [CustomAssetCategory("InputDevice")]
    public class InputDeviceDefinition : CustomAsset
    {
        [SerializeField]private int max_number_devices;
        [SerializeField]private InputDeviceDefinitionComponent[] components;

        [ContextMenu("Use")]
        private void Use()
        {
            ProjectSettings.ModifySettings("InputManager.asset", o => GenerateInternalAxises(o));
            CodeGenerator.GenerateCode("InputDevice", b => GenerateClass(b), false);
        }

        public void GenerateInternalAxises(SerializedObject obj)
        {
            SerializedProperty axises = obj.FindProperty("m_Axes");

            axises.ClearArray();
            for (int i = 1; i <= max_number_devices; i++)
                components.Process(c => c.GenerateInternalAxises(i, axises));
        }

        public void GenerateClass(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
            );

            writer.Write("[ApplicationEXSatellite]");
            writer.Write("static public class InputDeviceSatellite", delegate() {
                writer.Write("static private void Update()", delegate() {
                    writer.Write("InputDevice.GetInputDevices().Process(d => d.Update());");
                });
            });

            writer.Write("public class InputDevice", delegate() {
                for (int i = 1; i <= max_number_devices; i++)
                    writer.Write("static public readonly InputDevice Device" + i + " = new InputDevice(" + i + ");");

                writer.Write("static public InputDevice GetInputDevice(int device_id)", delegate() {
                    writer.Write("switch(device_id)", delegate() {
                        for (int i = 1; i <= max_number_devices; i++)
                            writer.Write("case " + i + ": return Device" + i + ";");
                    });

                    writer.Write("throw new UnaccountedBranchException(\"device_id\", device_id);");
                });

                writer.Write("static public IEnumerable<InputDevice> GetInputDevices()", delegate() {
                    for (int i = 1; i <= max_number_devices; i++)
                        writer.Write("yield return Device" + i + ";");
                });

                writer.Write("private InputDevice(int device_id)", delegate() {
                    components.Process(c => c.GenerateClassConstructor(builder, "device_id"));
                });

                writer.Write("public void Update()", delegate() {
                    components.Process(c => c.GenerateClassUpdate(builder));
                });

                components.Process(c => c.GenerateClassMembers(builder));
            });
        }
    }
}