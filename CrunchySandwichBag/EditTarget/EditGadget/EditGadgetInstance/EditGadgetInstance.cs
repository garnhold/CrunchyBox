using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public abstract class EditGadgetInstance
    {
        private EditGadget gadget;

        public abstract void Execute(string name);

        public abstract void SetContents(object value);
        public abstract void SetAuxContents(string name, object value);

        public abstract object GetContents();
        public abstract object GetAuxContents(string name);

        public EditGadgetInstance(EditGadget g)
        {
            gadget = g;
        }

        public T GetContents<T>()
        {
            return GetContents().ConvertEX<T>();
        }

        public T GetAuxContents<T>(string name)
        {
            return GetAuxContents(name).ConvertEX<T>();
        }

        public EditGadget GetGadget()
        {
            return gadget;
        }

        public EditorSceneElement CreateEditorSceneElement()
        {
            return gadget.GetEditorSceneElementEditGadgetInstanceType().CreateInstance<EditorSceneElement>(this);
        }
    }
}