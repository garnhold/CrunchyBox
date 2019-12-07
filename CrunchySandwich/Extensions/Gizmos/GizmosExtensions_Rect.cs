using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawRect(Rect rect)
        {
            DrawWireCube(rect.GetSpacar());
        }
    }
}