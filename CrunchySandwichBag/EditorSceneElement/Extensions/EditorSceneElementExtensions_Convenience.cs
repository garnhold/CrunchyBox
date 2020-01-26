using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class EditorSceneElementExtensions_Convenience
    {
        static public EditorSceneElement InitilizeAndGet(this EditorSceneElement item)
        {
            item.Initilize();

            return item;
        }
    }
}