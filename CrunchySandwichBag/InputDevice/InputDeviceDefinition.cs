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

            writer.Write("public class InputDevice", delegate() {
                for (int i = 1; i <= max_number_devices; i++)
                    writer.Write("static public readonly InputDevice Device" + i + " = new InputDevice(" + i + ");");

                writer.Write("public InputDevice(int device_id)", delegate() {
                    components.Process(c => c.GenerateClassConstructor(builder, "device_id"));
                });

                components.Process(c => c.GenerateClassMembers(builder));
            });
        }
    }
}