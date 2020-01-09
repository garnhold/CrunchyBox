using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class UnityObjectExtensions_SceneObject
    {
        static public bool IsSceneObject(this UnityEngine.Object item)
        {
            if (item.Is<GameObject>() && item.IsPrefab() == false)
                return true;

            return false;
        }
    }
}