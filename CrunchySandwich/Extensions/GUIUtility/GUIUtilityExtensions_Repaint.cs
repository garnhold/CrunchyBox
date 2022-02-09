using System;

using Crunchy.Dough;
using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIUtilityExtensions
    {
        static public void ForceRepaint()
        {
            if (Event.current.type == EventType.Repaint)
                Event.current.Use();
        }
    }
}