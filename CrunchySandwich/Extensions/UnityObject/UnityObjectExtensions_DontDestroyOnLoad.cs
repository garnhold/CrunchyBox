using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class UnityObjectExtensions_DontDestroyOnLoad
    {
        static public void DontDestroyOnLoad(this UnityEngine.Object item)
        {
            UnityEngine.Object.DontDestroyOnLoad(item);
        }
    }
}