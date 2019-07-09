using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public class SpriteSequence
    {
        [SerializeField]private string name;
        [SerializeField]private SpriteSequenceFrame[] frames;

        public SpriteSequence()
        {
        }

        public SpriteSequence(string n, IEnumerable<SpriteSequenceFrame> f)
        {
            name = n;
            frames = f.ToArray();
        }

        public SpriteSequence(string n, float v, IEnumerable<Sprite> s) : this(n, s.Convert(i => new SpriteSequenceFrame(v, i))) { }
        public SpriteSequence(float v, IEnumerable<Sprite> s) : this("Sequence", v, s) { }
        public SpriteSequence(IEnumerable<Sprite> s) : this(1.0f, s) { }

        public string GetName()
        {
            return name;
        }

        public int GetNumberFrames()
        {
            return frames.Length;
        }

        public Sprite GetFirstFrame()
        {
            return frames.GetFirst().IfNotNull(f => f.GetSprite());
        }

        public Sprite GetFrameByIndex(int index)
        {
            return frames.GetLooped(index).IfNotNull(f => f.GetSprite());
        }

        public Sprite GetFrameByValue(float value)
        {
            float total_value = 0.0f;

            foreach (SpriteSequenceFrame frame in frames)
            {
                total_value += frame.GetValue();

                if (value <= total_value)
                    return frame.GetSprite();
            }

            return GetFrameByValue(value.GetLooped(total_value));
        }

        public IEnumerable<Sprite> GetFrames()
        {
            return frames.Convert(f => f.GetSprite());
        }
    }
}