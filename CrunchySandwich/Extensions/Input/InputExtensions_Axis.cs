using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static public float GetKeyAxis(KeyCode left, KeyCode right)
        {
            return Input.GetKey(left).ConvertBool(-1.0f) + Input.GetKey(right).ConvertBool(1.0f);
        }
    }
}