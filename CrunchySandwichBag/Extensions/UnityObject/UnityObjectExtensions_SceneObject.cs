using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;

    static public class UnityObjectExtensions_SceneObject
    {
        static public bool IsSceneObject(this UnityEngine.Object item)
        {
            GameObject game_object;

            if (item.Convert<GameObject>(out game_object))
            {
                if (game_object.scene.IsValid())
                    return true;
            }

            return false;
        }
    }
}