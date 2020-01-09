using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class UnityObjectExtensions_DontDestroyOnLoad
    {
        static public void DontDestroyOnLoad(this UnityEngine.Object item)
        {
            UnityEngine.Object.DontDestroyOnLoad(item);
        }
    }
}