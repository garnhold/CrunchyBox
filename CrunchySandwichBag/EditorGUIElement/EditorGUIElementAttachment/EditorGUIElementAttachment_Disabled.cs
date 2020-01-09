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