using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class GizmosExtensions
    {
        static public void UseColor(Color new_color, Process process)
        {
            Color old_color = Gizmos.color;

            Gizmos.color = new_color;
                process();
            Gizmos.color = old_color;
        }
    }
}