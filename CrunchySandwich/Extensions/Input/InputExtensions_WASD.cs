using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static public Vector2 GetWASD2()
        {
            return InputExtensions.GetKeyStick(
                KeyCode.W,
                KeyCode.A,
                KeyCode.S,
                KeyCode.D
            );
        }

        static public Vector3 GetWASD3()
        {
            return GetWASD2().GetArear();
        }
    }
}