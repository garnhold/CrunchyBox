using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sauce;
    using Sandwich;
    
    static public class EditorSceneElementEditGadgetInstanceExtensions_Set
    {
        static public void SetContents(this EditorSceneElement_EditGadgetInstance item, object value)
        {
            item.GetGadgetInstance().SetContents(value);
        }

        static public void SetAuxContents(this EditorSceneElement_EditGadgetInstance item, string name, object value)
        {
            item.GetGadgetInstance().SetAuxContents(name, value);
        }
    }
}