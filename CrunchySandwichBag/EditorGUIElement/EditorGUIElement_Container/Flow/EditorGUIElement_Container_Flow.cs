using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_Container_Flow : EditorGUIElement_Container
    {
        public abstract void AddChild(EditorGUIFlowElement child);

        public T AddChild<T>(EditorGUIElementDimension d, T child) where T : EditorGUIElement
        {
            AddChild(new EditorGUIFlowElement(child, d));
            return child;
        }

        public T AddFixedChild<T>(float width, T child) where T : EditorGUIElement
        {
            return AddChild(EditorGUIElementDimension.Fixed(width), child);
        }

        public T AddWeightedChild<T>(float weight, T child) where T : EditorGUIElement
        {
            return AddChild(EditorGUIElementDimension.Weighted(weight), child);
        }

        public T AddAtleastChild<T>(float weight, float minimum, T child) where T : EditorGUIElement
        {
            return AddChild(EditorGUIElementDimension.Atleast(weight, minimum), child);
        }
    }
}