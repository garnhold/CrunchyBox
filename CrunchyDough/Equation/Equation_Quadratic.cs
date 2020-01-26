using System;

namespace Crunchy.Dough
{    
    public class Equation_Quadratic : Equation
    {
        private QuadraticEquation quadratic_equation;

        public Equation_Quadratic(QuadraticEquation e)
        {
            quadratic_equation = e;
        }

        public Equation_Quadratic(float a, float b, float c) : this(new QuadraticEquation(a, b, c)) { }
        public Equation_Quadratic(float x1, float y1, float x2, float y2, float x3, float y3) : this(new QuadraticEquation(x1, y1, x2, y2, x3, y3)) { }
        public Equation_Quadratic(float x1, float x2, float x3, Operation<float, float> o) : this(new QuadraticEquation(x1, x2, x3, o)) { }

        public override float Evaluate(float x)
        {
            return quadratic_equation.Evaluate(x);
        }
    }
}