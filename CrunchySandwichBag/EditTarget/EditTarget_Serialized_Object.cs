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
    public class EditTarget_Serialized_Object : EditTarget_Serialized
    {
        private Type target_type;
        private SerializedObject serialized_object;

        protected override SerializedProperty GetPropertyInternal(string path)
        {
            return serialized_object.FindProperty(path);
        }

        protected override IEnumerable<SerializedProperty> GetPropertysInternal()
        {
            return serialized_object.GetImmediateChildren(true);
        }

        public EditTarget_Serialized_Object(SerializedObject o)
        {
            serialized_object = o;
            target_type = serialized_object.GetTargetType();
        }

        public override Type GetTargetType()
        {
            return target_type;
        }

        public override bool IsSerializationCorrupt()
        {
            return serialized_object.IsSerializationCorrupt();
        }
    }
}