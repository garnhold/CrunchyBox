using System;

using UnityEngine;

namespace Crunchy.Sandwich
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