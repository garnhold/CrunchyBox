using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class FunctionTableSegment
    {
        private float step_value;
        private int number_entrys;
        private int number_entrys_mask;

        private QuadraticEquation[] entrys;

        public FunctionTableSegment(float s, float e, int d, Operation<float, float> o)
        {
            number_entrys = d.CalculateContainerPOT();
            number_entrys_mask = number_entrys - 1;

            step_value = (e - s) / number_entrys;

            entrys = Floats.Range(s, e, step_value, false)
                .Convert(f => new FunctionTableSegmentEntry(f, step_value, o))
                .ToArray();
        }

        public float Evaluate(float x)
        {
            float index = x / step_value;
            int int_index = (int)index;

            return entrys[int_index & number_entrys_mask].Evaluate(index - int_index);
        }
    }
}