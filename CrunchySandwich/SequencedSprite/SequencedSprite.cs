﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [CustomAssetCategory("Sprite")]
    public class SequencedSprite : CustomAsset
    {
        [SerializeField]private SpriteSequence[] sequences;

        public void Initialize(IEnumerable<SpriteSequence> s)
        {
            sequences = s.ToArray();
        }
        public void Initialize(params SpriteSequence[] s)
        {
            Initialize((IEnumerable<SpriteSequence>)s);
        }

        public Sprite GetDefaultFrame()
        {
            return GetDefaultSequence().GetFirstFrame();
        }

        public SpriteSequence GetDefaultSequence()
        {
            return sequences.GetFirst();
        }

        public SpriteSequence GetSequence(string name)
        {
            return sequences.FindFirst(a => a.GetName() == name) ?? GetDefaultSequence();
        }
    }
}