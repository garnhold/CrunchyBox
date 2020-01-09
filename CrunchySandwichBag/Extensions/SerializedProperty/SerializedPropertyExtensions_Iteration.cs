using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class SerializedPropertyExtensions_Iteration
    {
        static public bool Next(this SerializedProperty item, bool only_visible, bool enter_children)
        {
            if (only_visible)
                return item.NextVisible(enter_children);

            return item.Next(enter_children);
        }
    }
}