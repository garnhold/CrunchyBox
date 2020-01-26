using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorGUIElementAttachment_Singular : EditorGUIElementAttachment
    {
        private string singular_id;

        public EditorGUIElementAttachment_Singular(string id)
        {
            singular_id = id;
        }

        public override bool PrepareElementForAttachment(EditorGUIElement element)
        {
            element.RemoveAttachments(delegate(EditorGUIElementAttachment attachment) {
                EditorGUIElementAttachment_Singular cast;

                if (attachment.Convert<EditorGUIElementAttachment_Singular>(out cast))
                {
                    if (cast.singular_id == singular_id)
                        return true;
                }

                return false;
            });

            return true;
        }
    }
}