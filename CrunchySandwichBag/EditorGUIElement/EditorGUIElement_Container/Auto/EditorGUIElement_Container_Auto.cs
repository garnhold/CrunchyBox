using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElement_Container_Auto : EditorGUIElement_Container
    {
        public abstract void AddChild(EditorGUIElement child);

        public T AddChild<T>(T child) where T : EditorGUIElement
        {
            AddChild((EditorGUIElement)child);
            return child;
        }

        public void AddChildren(IEnumerable<EditorGUIElement> children)
        {
            children.Process(c => AddChild(c));
        }
        public void AddChildren(params EditorGUIElement[] children)
        {
            AddChildren((IEnumerable<EditorGUIElement>)children);
        }
    }
}