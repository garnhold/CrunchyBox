﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Vector3Int
    {
        static public Vector3Int GetVector3Int(this Vector3 item)
        {
            return new Vector3Int((int)item.x, (int)item.y, (int)item.z);
        }
    }
}