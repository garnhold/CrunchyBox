using System;

using Crunchy.Dough;
using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIUtilityExtensions
    {
        static public void Unfocus()
        {
            GUIUtility.hotControl = 0;
            GUIUtility.keyboardControl = 0;
        }
    }
}