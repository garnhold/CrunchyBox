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
    public abstract class EditTarget_Serialized : EditTarget
    {
        protected abstract SerializedProperty GetPropertyInternal(string path);
        protected abstract IEnumerable<SerializedProperty> GetPropertysInternal();

        static public EditProperty CreateProperty(EditTarget target, SerializedProperty property)
        {
            if (property.IsTypicalArray())
                return new EditProperty_Array_Serialized(target, property);

            return new EditProperty_Value_Serialized(target, property);
        }
        protected EditProperty CreateProperty(SerializedProperty property)
        {
            return CreateProperty(this, property);
        }

        public override EditAction ForceAction(string path)
        {
            return null;
        }

        public override EditProperty ForceProperty(string path)
        {
            return CreateProperty(GetPropertyInternal(path));
        }

        public override IEnumerable<EditAction> GetActions()
        {
            return Empty.IEnumerable<EditAction>();
        }

        public override IEnumerable<EditProperty> GetPropertys()
        {
            return GetPropertysInternal()
                .Skip(p => p.name == "m_Script")
                .Convert(p => CreateProperty(p))
                .Skip(p => p.HasCustomAttributeOfType<RecoveryFieldAttribute>(true));
        }

        public override IEnumerable<EditProperty> GetRecoveryPropertys()
        {
            return GetPropertysInternal()
                .Skip(p => p.name == "m_Script")
                .Convert(p => CreateProperty(p))
                .Narrow(p => p.HasCustomAttributeOfType<RecoveryFieldAttribute>(true));
        }

        public override IEnumerable<EditGadget> GetGadgets()
        {
            return Empty.IEnumerable<EditGadget>();
        }
    }
}