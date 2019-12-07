using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
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