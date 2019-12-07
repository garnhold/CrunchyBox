using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    
    static public class SerializedPropertyExtensions_Attributes
    {
        static public IEnumerable<Attribute> GetAllCustomAttributes(this SerializedProperty item, bool inherit)
        {
            return item.GetVariable().GetAllCustomAttributes(inherit);
        }
    }
}