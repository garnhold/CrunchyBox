using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sauce;
    using Sandwich;
    
    public abstract class EditorSceneElement_EditGadgetInstance : EditorSceneElement
    {
        private EditGadgetInstance gadget_instance;

        public EditorSceneElement_EditGadgetInstance(EditGadgetInstance g)
        {
            gadget_instance = g;
        }

        public EditGadgetInstance GetGadgetInstance()
        {
            return gadget_instance;
        }
    }
}