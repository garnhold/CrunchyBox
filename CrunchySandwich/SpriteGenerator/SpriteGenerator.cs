﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Sauce;

    public abstract class SpriteGenerator : CustomAsset
    {
        [SerializeField] private int frame_width;
        [SerializeField] private int frame_height;
        [SerializeField] private float frames_per_second;

        public SpriteGeneratorSheet GenerateSheet()
        {
            return new SpriteGeneratorSheet(
                1.0f / frames_per_second,
                new VectorI2(frame_width, frame_height)
            );
        }
    }
}