using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class ComponentExtensions_IEnumerable_GameObject
    {
        static public IEnumerable<GameObject> ConvertToGameObjects<T>(this IEnumerable<T> item) where T : Component
        {
            return item.Convert(c => c.gameObject);
        }

        static public void DestroyGameObjects<T>(this IEnumerable<T> item) where T : Component
        {
            item.ConvertToGameObjects().SkipNull().Destroy();
        }

        static public void DestroyGameObjectsImmediate<T>(this IEnumerable<T> item, bool is_asset = false) where T : Component
        {
            item.ConvertToGameObjects().SkipNull().DestroyImmediate(is_asset);
        }

        static public void DestroyGameObjectsAdvisory<T>(this IEnumerable<T> item, bool is_asset = false) where T : Component
        {
            item.ConvertToGameObjects().SkipNull().DestroyAdvisory(is_asset);
        }
    }
}