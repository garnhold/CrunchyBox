using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public void PushPopColor(Color color, Process process)
        {
            Color old_color = GUI.color;

            GUI.color = color;
                process();
            GUI.color = old_color;
        }
    }
}