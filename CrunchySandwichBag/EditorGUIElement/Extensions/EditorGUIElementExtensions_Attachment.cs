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