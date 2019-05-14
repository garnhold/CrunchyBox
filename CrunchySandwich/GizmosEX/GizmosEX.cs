using System;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class GizmosEX
    {
        static public void DrawGizmos(Process process)
        {
            ApplicationEX.GetInstance().RegisterDrawGizmos(process);
        }
    }
}