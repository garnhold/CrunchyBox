using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public GUIControlHandle GetControlHandle(FocusType focus_type)
        {
            return new GUIControlHandle(focus_type);
        }
    }
}