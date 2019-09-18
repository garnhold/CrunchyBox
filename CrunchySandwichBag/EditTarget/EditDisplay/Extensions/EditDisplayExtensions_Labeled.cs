using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditDisplayExtensions_Labeled
    {
        static public EditorGUIElement CreateLabeledEditorGUIElement(this EditDisplay item)
        {
            return item.CreateEditorGUIElement().LabelWithGUIContent(item.CreateGUIContentLabel());
        }

        static public EditorGUIElement CreateBlockLabeledEditorGUIElement(this EditDisplay item)
        {
            return item.CreateEditorGUIElement().LabelWithGUIContentBlock(item.CreateGUIContentLabel());
        }
    }
}