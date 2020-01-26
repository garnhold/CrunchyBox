using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class EditorGUIElementExtensions_Attachment
    {
        static public IEnumerable<T> GetAttachments<T>(this EditorGUIElement item)
        {
            return item.GetAttachments().Convert<EditorGUIElementAttachment, T>();
        }

        static public T GetAttachment<T>(this EditorGUIElement item)
        {
            return item.GetAttachments<T>().GetFirst();
        }
    }
}