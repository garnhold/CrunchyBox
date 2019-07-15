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
    [AssetClassCategory("Input")]
    public abstract class InputDeviceDefinitionComponent : CustomAsset
    {
        public abstract void GenerateInternalAxises(int device_id, SerializedProperty axises);

        public abstract void GenerateClassConstructor(CSTextDocumentBuilder builder, string device_id);
        public abstract void GenerateClassMembers(CSTextDocumentBuilder builder);

        [SerializeField]private string name;

        protected void PushInternalButton(SerializedProperty property, string name, int device_id, string button)
        {
            property.SetChildValue("m_Name", GetName() + device_id);

            property.SetChildValue("positiveButton", button);

            property.SetChildValue("gravity", 3.0f);
            property.SetChildValue("dead", 0.1f);
            property.SetChildValue("sensitivity", 1.0f);
            property.SetChildValue("snap", true);
        }

        protected void PushInternalJoystickAxis(SerializedProperty property, string name, int device_id, int axis_id, bool invert, bool snap, float gravity, float dead, float sensitivity)
        {
            property.SetChildValue("m_Name", name + device_id);

            property.SetChildValue("type", 2);
            property.SetChildValue("joyNum", device_id);
            property.SetChildValue("axis", axis_id);

            property.SetChildValue("invert", invert);
            property.SetChildValue("snap", snap);

            property.SetChildValue("gravity", gravity);
            property.SetChildValue("dead", dead);
            property.SetChildValue("sensitivity", sensitivity);
        }

        public string GetName()
        {
            return name;
        }

        public void GenerateEnumMember(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "ENUM", GetName().StyleAsEnumName()
            );

            writer.Write("?ENUM, ");
        }

        public void GenerateGetCase(CSTextDocumentBuilder builder, string enum_type)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "VARIABLE", GetName().StyleAsVariableName(),
                "ENUM", GetName().StyleAsEnumName(),
                "ENUM_TYPE", enum_type
            );

            writer.Write("case ?ENUM_TYPE.?ENUM: return ?VARIABLE;");
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