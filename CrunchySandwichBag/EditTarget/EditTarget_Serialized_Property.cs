using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
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