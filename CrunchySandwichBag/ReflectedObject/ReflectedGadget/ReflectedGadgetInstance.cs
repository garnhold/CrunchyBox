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
    public partial class ReflectedGadget
    {
        public class Instance
        {
            private ReflectedGadget gadget;
            private object target;

            public Instance(ReflectedGadget g, object t)
            {
                gadget = g;
                target = t;
            }

            public void Execute(string name)
            {
                gadget.Execute(target, name);
            }

            public void SetContents(object value)
            {
                gadget.SetContents(target, value);
            }

            public void SetAuxContents(string name, object value)
            {
                gadget.SetAuxContents(target, name, value);
            }

            public object GetContents()
            {
                return gadget.GetContents(target);
            }
            public T GetContents<T>()
            {
                return GetContents().ConvertEX<T>();
            }

            public object GetAuxContents(string name)
            {
                return gadget.GetAuxContents(target, name);
            }
            public T GetAuxContents<T>(string name)
            {
                return GetAuxContents(name).ConvertEX<T>();
            }
        }
    }
}