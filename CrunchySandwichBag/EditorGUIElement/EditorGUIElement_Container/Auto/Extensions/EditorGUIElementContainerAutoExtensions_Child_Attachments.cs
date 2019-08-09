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
    static public class EditorGUIElementContainerAutoExtensions_Child_Attachments
    {
        static public T AddChildWithAttachments<T>(this EditorGUIElement_Container_Auto item, T child, IEnumerable<EditorGUIElementAttachment> attachments) where T : EditorGUIElement
        {
            item.AddChild(child);
            child.AddAttachments(attachments);

            return child;
        }
        static public T AddChildWithAttachments<T>(this EditorGUIElement_Container_Auto item, T child, params EditorGUIElementAttachment[] attachments) where T : EditorGUIElement
        {
            return item.AddChildWithAttachments(child, (IEnumerable<EditorGUIElementAttachment>)attachments);
        }
    }
}