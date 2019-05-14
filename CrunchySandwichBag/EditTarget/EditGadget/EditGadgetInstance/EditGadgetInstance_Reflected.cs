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
    public class EditGadgetInstance_Reflected : EditGadgetInstance
    {
        private ReflectedGadget.Instance instance;

        public EditGadgetInstance_Reflected(EditGadget g, ReflectedGadget.Instance i) : base(g)
        {
            instance = i;
        }

        public override void Execute(string name)
        {
            instance.Execute(name);
        }

        public override void SetContents(object value)
        {
            instance.SetContents(value);
        }

        public override void SetAuxContents(string name, object value)
        {
            instance.SetAuxContents(name, value);
        }

        public override object GetContents()
        {
            return instance.GetContents();
        }

        public override object GetAuxContents(string name)
        {
            return instance.GetAuxContents(name);
        }
    }
}