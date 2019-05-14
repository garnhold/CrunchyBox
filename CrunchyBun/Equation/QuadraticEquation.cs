using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class QuadraticEquation
    {
        private float x2_coeff;
        private float x_coeff;
        private float constant;

        public QuadraticEquation(float a, float b, float c)
        {
            x2_coeff = a;
            x_coeff = b;
            constant = c;
        }

        public QuadraticEquation(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            x2_coeff = (y1 - y3 + ((y2 - y3) / (x2 - x3)) * (x3 - x1)) / (x1*x1 - x3*x3 + (x2 + x3)*(x3 - x1));
            x_coeff = ((y2 - y3) / (x2 - x3)) - x2_coeff*(x2 + x3);
            constant = y3 - x2_coeff*x3*x3 - x_coeff*x3;
        }

        public QuadraticEquation(float x1, float x2, float x3, Operation<float, float> o) : this(x1, o(x1), x2, o(x2), x3, o(x3)) { }

        public float Evaluate(float x)
        {
            return x2_coeff*x*x + x_coeff*x + constant;
        }
    }
}