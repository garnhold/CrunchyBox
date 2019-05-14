﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditorGUIElementExtensions_GUIContentLabel
    {
        static public T LabelWithGUIContent<T>(this T item, GUIContent label) where T : EditorGUIElement
        {
            item.AddAttachment(new EditorGUIElementAttachment_Singular_GUIContentLabel_Inline(label));

            return item;
        }
        static public T LabelWithGUIContent<T>(this T item, string label) where T : EditorGUIElement
        {
            return item.LabelWithGUIContent(new GUIContent(label));
        }

        static public T LabelWithGUIContentBlock<T>(this T item, GUIContent label) where T : EditorGUIElement
        {
            item.AddAttachment(new EditorGUIElementAttachment_Singular_GUIContentLabel_Block(label));

            return item;
        }
        static public T LabelWithGUIContentBlock<T>(this T item, string label) where T : EditorGUIElement
        {
            return item.LabelWithGUIContentBlock(new GUIContent(label));
        }
    }
}