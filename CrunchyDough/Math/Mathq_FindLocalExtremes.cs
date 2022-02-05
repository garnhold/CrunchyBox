using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public partial class Mathq
    {
        static public IEnumerable<float> FindLocalExtremes(float bound_a, float bound_b, Operation<float, float> function, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            Operation<float, float> derivative = Mathq.GetDerivative(function);

            return Mathq.FindMultiEdge(bound_a, bound_b, x => derivative(x) > 0.0f, divisions, margin, max_iterations);
        }

        static public float FindMaximum(float bound_a, float bound_b, Operation<float, float> function, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.FindLocalExtremes(bound_a, bound_b, function, divisions, margin, max_iterations)
                .Append(bound_a, bound_b)
                .FindHighestRated(x => function(x));
        }

        static public float FindMinimum(float bound_a, float bound_b, Operation<float, float> function, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.FindLocalExtremes(bound_a, bound_b, function, divisions, margin, max_iterations)
                .Append(bound_a, bound_b)
                .FindLowestRated(x => function(x));
        }
    }
}