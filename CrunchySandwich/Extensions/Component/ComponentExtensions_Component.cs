using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class ComponentExtensions_Component
    {
        static public Component AddComponent(this Component item, Type type)
        {
            return item.gameObject.AddComponent(type);
        }
        static public T AddComponent<T>(this Component item) where T : Component
        {
            return item.AddComponent(typeof(T)).Convert<T>();
        }
    }
}