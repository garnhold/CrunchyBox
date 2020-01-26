using System;

namespace Crunchy.Dough
{    
    public class Equation_Linear : Equation
    {
        private LinearEquation linear_equation;

        public Equation_Linear(LinearEquation e)
        {
            linear_equation = e;
        }

        public Equation_Linear(float m, float b) : this(new LinearEquation(m, b)) { }
        public Equation_Linear(float x1, float y1, float x2, float y2) : this(new LinearEquation(x1, y1, x2, y2)) { }
        public Equation_Linear(float x1, float x2, Operation<float, float> o) : this(new LinearEquation(x1, x2, o)) { }

        public override float Evaluate(float x)
        {
            return linear_equation.Evaluate(x);
        }
    }
}