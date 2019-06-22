using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [Serializable]
    public class SpriteSequenceFormat
    {
        [SerializeField]private string name;
        [SerializeField]private SpriteSequenceFrameFormat[] frame_formats;

        public SpriteSequence CreateSpriteSequence(Texture2D texture)
        {
            return new SpriteSequence(name, frame_formats.Convert(f => f.CreateSpriteSequenceFrame(texture)));
        }
    }
}