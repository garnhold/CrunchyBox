using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Attributes
    {
        static public IEnumerable<Attribute> GetAllCustomAttributes(this SerializedProperty item, bool inherit)
        {
            return item.GetVariable().GetAllCustomAttributes(inherit);
        }
    }
}