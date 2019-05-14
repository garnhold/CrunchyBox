using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class GameObjectExtensions_IEnumerable_Destroy
    {
        static public void Destroy(this IEnumerable<GameObject> item)
        {
            item.Process(o => o.Destroy());
        }

        static public void DestroyImmediate(this IEnumerable<GameObject> item, bool is_asset = false)
        {
            item.ProcessCopy(o => o.DestroyImmediate(is_asset));
        }

        static public void DestroyAdvisory(this IEnumerable<GameObject> item, bool is_asset = false)
        {
            item.Process(o => o.DestroyAdvisory(is_asset));
        }
    }
}