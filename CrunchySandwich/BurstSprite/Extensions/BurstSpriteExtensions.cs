﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class BurstSpriteExtensions
    {
        static public BurstSpriteRenderer Deploy(this BurstSprite item, Vector2 position)
        {
            return item.Deploy().Chain(r => r.SetPlanarPosition(position));
        }
    }
}