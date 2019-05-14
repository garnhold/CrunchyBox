using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class SpectrumBand<T>
    {
        private T data;

        private float start;
        private float end;

        public SpectrumBand(T d, float v1, float v2)
        {
            data = d;
            v1.Order(v2, out start, out end);
        }

        public T GetData()
        {
            return data;
        }

        public float GetStart()
        {
            return start;
        }

        public float GetEnd()
        {
            return end;
        }
    }
}