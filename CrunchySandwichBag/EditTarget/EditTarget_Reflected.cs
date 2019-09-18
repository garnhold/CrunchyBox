using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditTarget_Reflected : EditTarget
    {
        private ReflectedObject reflected_object;

        static public EditAction CreateAction(EditTarget target, ReflectedAction action)
        {
            return new EditAction_Reflected(target, action);
        }
        protected EditAction CreateAction(ReflectedAction action)
        {
            return CreateAction(this, action);
        }

        static public EditDisplay CreateDisplay(EditTarget target, ReflectedDisplay display)
        {
            return new EditDisplay_Reflected(target, display);
        }
        protected EditDisplay CreateDisplay(ReflectedDisplay display)
        {
            return CreateDisplay(this, display);
        }

        static public EditProperty CreateProperty(EditTarget target, ReflectedProperty property)
        {
            ReflectedProperty_Single_Value value;
            ReflectedProperty_Single_Object obj;
            ReflectedProperty_Array array;

            if (property.Convert<ReflectedProperty_Single_Value>(out value))
                return new EditProperty_Single_Value_Reflected(target, value);

            if (property.Convert<ReflectedProperty_Single_Object>(out obj))
                return new EditProperty_Single_Object_Reflected(target, obj);

            if (property.Convert<ReflectedProperty_Array>(out array))
                return new EditProperty_Array_Reflected(target, array);

            throw new UnaccountedBranchException("property.GetType()", property.GetTypeEX());
        }
        protected EditProperty CreateProperty(ReflectedProperty property)
        {
            return CreateProperty(this, property);
        }

        static public EditGadget CreateGadget(EditTarget target, ReflectedGadget gadget)
        {
            return new EditGadget_Reflected(target, gadget);
        }
        protected EditGadget CreateGadget(ReflectedGadget gadget)
        {
            return CreateGadget(this, gadget);
        }

        public EditTarget_Reflected(ReflectedObject o)
        {
            reflected_object = o;
        }

        public override Type GetTargetType()
        {
            return reflected_object.GetObjectType();
        }

        public override bool IsSerializationCorrupt()
        {
            return reflected_object.IsSerializationCorrupt();
        }

        public override EditAction ForceAction(string path)
        {
            return CreateAction(reflected_object.ForceAction(path));
        }

        public override EditDisplay ForceDisplay(string path)
        {
            return CreateDisplay(reflected_object.ForceDisplay(path));
        }

        public override EditProperty ForceProperty(string path)
        {
            return CreateProperty(reflected_object.ForceProperty(path));
        }

        public override IEnumerable<EditAction> GetActions()
        {
            return reflected_object.GetActions()
                .Convert(a => CreateAction(a));
        }

        public override IEnumerable<EditAction> GetRecoveryActions()
        {
            return reflected_object.GetRecoveryActions()
                .Convert(a => CreateAction(a));
        }

        public override IEnumerable<EditDisplay> GetDisplays()
        {
            return reflected_object.GetDisplays()
                .Convert(d => CreateDisplay(d));
        }

        public override IEnumerable<EditProperty> GetPropertys()
        {
            return reflected_object.GetPropertys()
                .Convert(p => CreateProperty(p));
        }

        public override IEnumerable<EditProperty> GetRecoveryPropertys()
        {
            return reflected_object.GetRecoveryPropertys()
                .Convert(p => CreateProperty(p));
        }

        public override IEnumerable<EditGadget> GetGadgets()
        {
            return reflected_object.GetGadgets()
                .Convert(g => CreateGadget(g));
        }
    }
}