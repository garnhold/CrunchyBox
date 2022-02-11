using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
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

        public SpriteSequence(string n, float v, IEnumerable<Sprite> s) : this(n, s.Convert(i => new SpriteSequenceFrame(v, 0.0f, i))) { }
        public SpriteSequence(float v, IEnumerable<Sprite> s) : this("Sequence", v, s) { }
        public SpriteSequence(IEnumerable<Sprite> s) : this(1.0f, s) { }

        [InspectorFunction]
        public void ReinitializeWithSprites(List<UnityEngine.Object> sprites)
        {
            frames = sprites.Convert<UnityEngine.Object, Sprite>()
                .Convert(s => new SpriteSequenceFrame(s))
                .ToArray();
        }

        public string GetName()
        {
            return name;
        }

        public int GetNumberFrames()
        {
            return frames.Length;
        }

        public SpriteSequenceFrame GetFirstFrame()
        {
            return frames.GetFirst();
        }

        public SpriteSequenceFrame GetFrameByIndex(int index)
        {
            return frames.GetLooped(index);
        }

        public SpriteSequenceFrame GetFrameByValue(float value)
        {
            float total_value = 0.0f;

            foreach (SpriteSequenceFrame frame in frames)
            {
                total_value += frame.GetValue();

                if (value <= total_value)
                    return frame;
            }

            if (total_value <= 0.0f)
                return GetFirstFrame();

            return GetFrameByValue(value.GetLooped(total_value));
        }

        public IEnumerable<SpriteSequenceFrame> GetFrames()
        {
            return frames;
        }
    }
}