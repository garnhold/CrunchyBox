using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static public Vector2 GetKeyStick(KeyCode up, KeyCode left, KeyCode down, KeyCode right)
        {
            return new Vector2(
                InputExtensions.GetKeyAxis(left, right),
                InputExtensions.GetKeyAxis(down, up)
            ).BindMagnitudeBelow(1.0f);
        }
    }
}