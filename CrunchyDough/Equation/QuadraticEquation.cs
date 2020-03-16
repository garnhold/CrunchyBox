using System;

namespace Crunchy.Dough
{    
    public class QuadraticEquation
    {
        private float a;
        private float b;
        private float c;

        public QuadraticEquation(float na, float nb, float nc)
        {
            a = na;
            b = nb;
            c = nc;
        }

        public QuadraticEquation(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            a = (y1 - y3 + ((y2 - y3) / (x2 - x3)) * (x3 - x1)) / (x1*x1 - x3*x3 + (x2 + x3)*(x3 - x1));
            b = ((y2 - y3) / (x2 - x3)) - a*(x2 + x3);
            c = y3 - a*x3*x3 - b*x3;
        }

        public QuadraticEquation(float x1, float x2, float x3, Operation<float, float> o) : this(x1, o(x1), x2, o(x2), x3, o(x3)) { }

        public float Evaluate(float x)
        {
            return a*x*x + b*x + c;
        }

        public float GetA()
        {
            return a;
        }

        public float GetB()
        {
            return b;
        }

        public float GetC()
        {
            return c;
        }
    }
}