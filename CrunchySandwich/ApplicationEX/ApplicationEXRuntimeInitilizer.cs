using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class ApplicationEXRuntimeInitilizer
    {
        static private GameObject LIASON = null;

        [RuntimeInitializeOnLoadMethod]
        static private void Initilize()
        {
            if (LIASON == null)
            {
                LIASON = new GameObject("ApplicationEX", typeof(ApplicationEXLiason));
                LIASON.DontDestroyOnLoad();
            }
        }
    }
}