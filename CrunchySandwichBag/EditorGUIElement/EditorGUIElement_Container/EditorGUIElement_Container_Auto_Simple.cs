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
    public abstract class EditorGUIElement_Container_Auto_Simple : EditorGUIElement_Container_Auto
    {
        private List<EditorGUIElement> elements;

        public EditorGUIElement_Container_Auto_Simple()
        {
            elements = new List<EditorGUIElement>();
        }

        public override void AddChild(EditorGUIElement child)
        {
            if (child != null)
            {
                elements.Add(child);

                Invalidate();
                child.SetParent(this);
            }
        }

        public override void ClearChildren()
        {
            elements.Clear();

            Invalidate();
        }

        public override bool RemoveChild(EditorGUIElement child)
        {
            if (elements.Remove(child))
            {
                Invalidate();

                return true;
            }

            return false;
        }

        public override IEnumerable<EditorGUIElement> GetChildren()
        {
            return elements;
        }
    }
}