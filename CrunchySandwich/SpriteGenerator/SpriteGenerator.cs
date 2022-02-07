using System;
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
        [SerializeFieldEX] private Duration duration;

        public SpriteGeneratorSheet GenerateSheet()
        {
            return SpriteGeneratorSheet.CreateDuration(
                new VectorI2(frame_width, frame_height),
                duration.GetSeconds(),
                frames_per_second
            );
        }
    }
}