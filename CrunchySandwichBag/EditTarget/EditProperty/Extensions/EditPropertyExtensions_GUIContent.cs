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
    static public class EditPropertyExtensions_GUIContent
    {
        static public GUIContent GetGUIContentLabel(this EditProperty item)
        {
            return new GUIContent(item.GetName().StyleEntityForDisplay());
        }
    }
}