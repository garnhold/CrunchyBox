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
    public class EditorGUIElementAttachment_Disabled : EditorGUIElementAttachment
    {
        public override void PreDrawInternal()
        {
            EditorGUI.BeginDisabledGroup(true);
        }

        public override void PostDrawInternal()
        {
            EditorGUI.EndDisabledGroup();
        }
    }
}