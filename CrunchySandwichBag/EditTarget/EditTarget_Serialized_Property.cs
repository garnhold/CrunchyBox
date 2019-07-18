using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditTarget_Serialized_Property : EditTarget_Serialized
    {
        private SerializedProperty property;

        protected override SerializedProperty GetPropertyInternal(string path)
        {
            return property.ForceProperty(path);
        }

        protected override IEnumerable<SerializedProperty> GetPropertysInternal()
        {
            return property.GetImmediateChildren(true);
        }

        public EditTarget_Serialized_Property(SerializedProperty p)
        {
            property = p;
        }

        public override Type GetTargetType()
        {
            return property.GetVariableType();
        }

        public override bool IsSerializationCorrupt()
        {
            return false;
        }
    }
}