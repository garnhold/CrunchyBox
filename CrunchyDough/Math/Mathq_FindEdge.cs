using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public partial class Mathq
    {
        static public bool TryFindEdge(float bound_a, float bound_b, Predicate<float> predicate, out float x, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.TrySolve(0.0f, bound_a, bound_b, z => predicate(z).ConvertBool(1.0f, -1.0f), out x, margin, max_iterations);
        }
        static public float FindEdge(float bound_a, float bound_b, Predicate<float> predicate, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            float x;

            TryFindEdge(bound_a, bound_b, predicate, out x, margin, max_iterations);
            return x;
        }

        static public IEnumerable<float> FindMultiEdge(float bound_a, float bound_b, Predicate<float> predicate, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.MultiSolve(0.0f, bound_a, bound_b, x => predicate(x).ConvertBool(1.0f, -1.0f), divisions, margin, max_iterations);
        }
    }
}