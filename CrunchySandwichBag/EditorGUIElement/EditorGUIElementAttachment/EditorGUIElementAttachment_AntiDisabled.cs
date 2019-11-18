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
    public class EditorGUIElementAttachment_AntiDisabled : EditorGUIElementAttachment
    {
        public override void PreDrawInternal()
        {
            EditorGUI.EndDisabledGroup();
        }

        public override void PostDrawInternal()
        {
            EditorGUI.BeginDisabledGroup(true);
        }
    }
}