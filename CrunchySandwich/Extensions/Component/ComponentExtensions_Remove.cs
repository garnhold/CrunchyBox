using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class ComponentExtensions_Remove
    {
        static public void RemoveSelf(this Component item)
        {
            UnityEngine.Object.Destroy(item);
        }
    }
}