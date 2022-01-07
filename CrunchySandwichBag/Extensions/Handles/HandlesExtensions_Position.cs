using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;

    static public partial class HandlesExtensions
    {
        static public Vector3 DoPositionHandle(Vector3 position, Quaternion rotation)
        {
            return Handles.DoPositionHandle(position, rotation);
        }
        static public Vector3 DoPositionHandle(Vector3 position)
        {
            return DoPositionHandle(position, Quaternion.identity);
        }
    }
}