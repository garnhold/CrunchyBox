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

        public override EditFunction ForceFunction(string path, IEnumerable<Type> parameter_types)
        {
            throw new MissingMethodException("No function exits for type " + GetTargetType() + " and path " + path);
        }

        public override EditAction ForceAction(string path)
        {
            throw new MissingMethodException("No action exists for type " + GetTargetType() + " and path " + path);
        }

        public override EditDisplay ForceDisplay(string path)
        {
            throw new MissingMethodException("No display exists for type " + GetTargetType() + " and path " + path);
        }

        public override EditProperty ForceProperty(string path)
        {
            return CreateProperty(GetPropertyInternal(path));
        }

        public override IEnumerable<EditFunction> GetFunctions()
        {
            return Empty.IEnumerable<EditFunction>();
        }

        public override IEnumerable<EditAction> GetActions()
        {
            return Empty.IEnumerable<EditAction>();
        }

        public override IEnumerable<EditAction> GetRecoveryActions()
        {
            return Empty.IEnumerable<EditAction>();
        }

        public override IEnumerable<EditDisplay> GetDisplays()
        {
            return Empty.IEnumerable<EditDisplay>();
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