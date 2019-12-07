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
    
    public abstract class EditGadget
    {
        private EditTarget target;

        public abstract string GetName();
        public abstract Type GetGadgetType();

        public abstract IEnumerable<EditGadgetInstance> GetInstances();
        public abstract Type GetEditorSceneElementEditGadgetInstanceType();

        public EditGadget(EditTarget t)
        {
            target = t;
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public EditorSceneElement CreateEditorSceneElement()
        {
            return new EditorSceneElement_Complex_EditGadget(this);
        }
    }
}