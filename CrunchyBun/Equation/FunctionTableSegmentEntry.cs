using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class FunctionTableSegmentEntry : QuadraticEquation
    {
        public FunctionTableSegmentEntry(float x, float dx, Operation<float, float> o) 
            : base(
                0.0f, o(x),
                0.5f, o(x + 0.5f*dx),
                1.0f, o(x + dx)
            )
        {
        }
    }
}