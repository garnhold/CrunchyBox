using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public class SpriteAnimation
    {
        [SerializeField]private string name;
        [SerializeField]private float duration;
        [SerializeField]private Sprite[] frames;

        public SpriteAnimation()
        {
        }

        public SpriteAnimation(string n, float d, IEnumerable<Sprite> f)
        {
            name = n;
            duration = d;
            frames = f.ToArray();
        }

        public string GetName()
        {
            return name;
        }

        public float GetDuration()
        {
            return duration;
        }

        public int GetNumberFrames()
        {
            return frames.Length;
        }

        public Sprite GetFirstFrame()
        {
            return frames.GetFirst();
        }

        public Sprite GetFrameByIndex(int index)
        {
            return frames.GetLooped(index);
        }

        public Sprite GetFrameByTime(float seconds)
        {
            return frames.GetPercentLooped(seconds / duration);
        }

        public IEnumerable<Sprite> GetFrames()
        {
            return frames;
        }
    }
}