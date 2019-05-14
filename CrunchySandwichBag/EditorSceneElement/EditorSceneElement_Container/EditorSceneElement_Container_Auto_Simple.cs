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
    public abstract class EditorSceneElement_Container_Auto_Simple : EditorSceneElement_Container_Auto
    {
        private List<EditorSceneElement> elements;

        public EditorSceneElement_Container_Auto_Simple()
        {
            elements = new List<EditorSceneElement>();
        }

        public override void AddChild(EditorSceneElement child)
        {
            if (child != null)
            {
                elements.Add(child);

                child.SetParent(this);
            }
        }

        public override void ClearChildren()
        {
            elements.Clear();
        }

        public override bool RemoveChild(EditorSceneElement child)
        {
            if (elements.Remove(child))
                return true;

            return false;
        }

        public override IEnumerable<EditorSceneElement> GetChildren()
        {
            return elements;
        }
    }
}