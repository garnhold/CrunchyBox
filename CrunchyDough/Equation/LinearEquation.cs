using System;

namespace Crunchy.Dough
{    
    public class LinearEquation
    {
        private float slope;
        private float intercept;

        public LinearEquation(float m, float b)
        {
            slope = m;
            intercept = b;
        }

        public LinearEquation(float x1, float y1, float x2, float y2)
        {
            slope = (y2 - y1) / (x2 - x1);
            intercept = y1 - slope*x1;
        }

        public LinearEquation(float x1, float x2, Operation<float, float> o) : this(x1, o(x1), x2, o(x2)) { }

        public float Evaluate(float x)
        {
            return slope*x + intercept;
        }
    }
}