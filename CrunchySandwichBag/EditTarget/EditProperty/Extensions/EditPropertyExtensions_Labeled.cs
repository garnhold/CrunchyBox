using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;    using Sandwich;
    
    static public class EditPropertyExtensions_Labeled
    {
        static public EditorGUIElement CreateLabeledEditorGUIElement(this EditProperty item)
        {
            return item.CreateEditorGUIElement().LabelWithGUIContent(item.CreateGUIContentLabel());
        }

        static public EditorGUIElement CreateBlockLabeledEditorGUIElement(this EditProperty item)
        {
            return item.CreateEditorGUIElement().LabelWithGUIContentBlock(item.CreateGUIContentLabel());
        }
    }
}