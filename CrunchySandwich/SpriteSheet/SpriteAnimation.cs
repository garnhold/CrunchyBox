using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [CustomAssetCategory("Sprite")]
    public class SpriteAnimation : CustomAsset
    {
        [SerializeField]private string name;
        [SerializeField]private Sprite[] frames;

        public void Initialize(string n, IEnumerable<Sprite> f)
        {
            name = n;
            frames = f.ToArray();
        }

        public string GetName()
        {
            return name;
        }

        public int GetNumberFrames()
        {
            return frames.Length;
        }

        public Sprite GetFrame(int index)
        {
            return frames.GetLooped(index);
        }

        public IEnumerable<Sprite> GetFrames()
        {
            return frames;
        }
    }
}