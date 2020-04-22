using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class CameraExtensions_MousePoint
    {
        static public Ray MouseToWorldRay(this Camera item)
        {
            return item.ScreenPointToRay(Event.current.mousePosition.ConvertFromGUIToScreen());
        }
    }
}