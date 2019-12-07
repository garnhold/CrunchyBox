using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using UnityEngine.Internal;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    static public class EditorGUIElementExtensions_Convenience
    {
        static public EditorGUIElement InitilizeAndGet(this EditorGUIElement item)
        {
            item.Initialize();

            return item;
        }
    }
}