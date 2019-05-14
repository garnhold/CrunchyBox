using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditTargetExtensions_ForceProperty
    {
        static public EditProperty_Value ForcePropertyValue(this EditTarget item, string path)
        {
            return item.ForceProperty(path).Convert<EditProperty_Value>();
        }

        static public EditProperty_Object ForcePropertyObject(this EditTarget item, string path)
        {
            return item.ForceProperty(path).Convert<EditProperty_Object>();
        }
    }
}