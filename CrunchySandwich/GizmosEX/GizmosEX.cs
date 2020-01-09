using System;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class GizmosEX
    {
        static public void DrawGizmos(Process process)
        {
            ApplicationEX.GetInstance().RegisterDrawGizmos(process);
        }
    }
}