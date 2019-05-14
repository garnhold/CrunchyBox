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
    static public class EditorGUIElementContainerHorizontalStripExtensions_Child_Attachments
    {
        static public T AddChildWithAttachments<T>(this EditorGUIElement_Container_HorizontalStrip item, EditorGUIElementLength length, T child, IEnumerable<EditorGUIElementAttachment> attachments) where T : EditorGUIElement
        {
            item.AddChild(length, child);
            child.AddAttachments(attachments);

            return child;
        }
        static public T AddChildWithAttachments<T>(this EditorGUIElement_Container_HorizontalStrip item, EditorGUIElementLength length, T child, params EditorGUIElementAttachment[] attachments) where T : EditorGUIElement
        {
            return item.AddChildWithAttachments(length, child, (IEnumerable<EditorGUIElementAttachment>)attachments);
        }

        static public T AddLabeledChild<T>(this EditorGUIElement_Container_HorizontalStrip item, string label, EditorGUIElementLength length, T child) where T : EditorGUIElement
        {
            return item.AddChildWithAttachments(length, child, new EditorGUIElementAttachment_Label(label));
        }
    }
}