using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditGadget_Reflected : EditGadget
    {
        private ReflectedGadget gadget;

        static public EditGadgetInstance CreateInstance(EditGadget gadget, ReflectedGadget.Instance instance)
        {
            return new EditGadgetInstance_Reflected(gadget, instance);
        }
        protected EditGadgetInstance CreateInstance(ReflectedGadget.Instance instance)
        {
            return CreateInstance(this, instance);
        }

        public EditGadget_Reflected(EditTarget t, ReflectedGadget g) : base(t)
        {
            gadget = g;
        }

        public override string GetName()
        {
            return gadget.GetVariableName();
        }

        public override Type GetGadgetType()
        {
            return gadget.GetVariableType();
        }

        public override IEnumerable<EditGadgetInstance> GetInstances()
        {
            return gadget.GetInstances()
                .Convert(i => CreateInstance(i));
        }

        public override Type GetEditorSceneElementEditGadgetInstanceType()
        {
            return gadget.GetCustomAttributeOfType<AttachEditGadgetAttribute>(true)
                .GetEditorSceneElementEditGadgetInstanceType();
        }
    }
}