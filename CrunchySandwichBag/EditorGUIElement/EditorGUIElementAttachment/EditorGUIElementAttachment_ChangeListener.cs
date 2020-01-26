using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElementAttachment_ChangeListener : EditorGUIElementAttachment
    {
        private Process process;
        private bool is_changed;

        public EditorGUIElementAttachment_ChangeListener(Process p)
        {
            process = p;
        }

        public override void PreDrawInternal()
        {
            EditorGUI.BeginChangeCheck();
        }

        public override void PostDrawInternal()
        {
            is_changed = EditorGUI.EndChangeCheck();
        }

        public override void UnwindInternal()
        {
            if (is_changed)
                process();
        }
    }
}