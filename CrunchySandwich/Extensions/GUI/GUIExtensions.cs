using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class GUIExtensions
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