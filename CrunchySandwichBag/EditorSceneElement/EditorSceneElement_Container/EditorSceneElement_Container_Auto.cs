using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorSceneElement_Container_Auto : EditorSceneElement_Container
    {
        public abstract void AddChild(EditorSceneElement child);

        public T AddChild<T>(T child) where T : EditorSceneElement
        {
            AddChild((EditorSceneElement)child);
            return child;
        }

        public void AddChildren(IEnumerable<EditorSceneElement> children)
        {
            children.Process(c => AddChild(c));
        }
        public void AddChildren(params EditorSceneElement[] children)
        {
            AddChildren((IEnumerable<EditorSceneElement>)children);
        }
    }
}