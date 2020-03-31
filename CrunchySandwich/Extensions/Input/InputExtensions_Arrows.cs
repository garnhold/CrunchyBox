using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static public Vector2 GetArrows2()
        {
            return InputExtensions.GetKeyStick(
                KeyCode.UpArrow,
                KeyCode.LeftArrow,
                KeyCode.DownArrow,
                KeyCode.RightArrow
            );
        }

        static public Vector3 GetArrows3()
        {
            return GetArrows2().GetArear();
        }
    }
}