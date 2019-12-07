using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    public class KeylessChord
    {
        private KeylessScale scale;
        private StaticOrderList<int> indexs;

        public KeylessChord(KeylessScale s, IEnumerable<int> i)
        {
            scale = s;
            indexs = new StaticOrderList<int>(i);
        }

        public KeylessChord(KeylessScale s, params int[] i) : this(s, (IEnumerable<int>)i) { }
        public KeylessChord(KeylessScale s, string i) : this(s, i.Convert(c => (int)c.ParseNumber())) { }

        public void Invert(int amount)
        {
            if (amount > 0)
                InvertUpward(amount);
            else
                InvertDownward(-amount);
        }

        public void InvertUpward()
        {
            indexs.Add(indexs.Pop() + scale.GetScaleSize());
        }
        public void InvertUpward(int amount)
        {
            for (int i = 0; i < amount; i++)
                InvertUpward();
        }

        public void InvertDownward()
        {
            indexs.Add(indexs.PopLast() - scale.GetScaleSize());
        }
        public void InvertDownward(int amount)
        {
            for (int i = 0; i < amount; i++)
                InvertDownward();
        }

        public IEnumerable<KeylessPitch> GetPitches()
        {
            return indexs.Convert(i => scale.GetPitch(i));
        }
    }
}