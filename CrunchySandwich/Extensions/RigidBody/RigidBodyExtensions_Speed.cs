﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RigidBodyExtensions_Speed
    {
        static public float GetSpeed(this Rigidbody item)
        {
            return item.velocity.GetMagnitude();
        }
    }
}