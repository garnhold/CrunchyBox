using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public partial class Mathq
    {
        public const float DEFAULT_SOLVE_MARGIN = 1e-5f;
        public const int DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS = 1024;

        public const int DEFAULT_SOLVE_ALL_MAX_DEPTH = 4;

        static public bool TrySolve(float target, float bound_a, float bound_b, Operation<float, float> operation, out float x, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            float y;

            float below_bound;
            float above_bound;

            float below_value;
            float above_value;

            bound_a.OrderPairBySecond(operation(bound_a), bound_b, operation(bound_b), out below_bound, out below_value, out above_bound, out above_value);

            if(target <= below_value)
            {
                x = below_bound;
                if(target == below_value)
                    return true;

                return false;
            }

            if(target >= above_value)
            {
                x = above_bound;
                if(target == above_value)
                    return true;

                return false;
            }

            x = 0.0f;
            for (int i = 0; i < max_iterations; i++ )
            {
                x = (below_bound + above_bound) * 0.5f;
                y = operation(x);

                if ((above_bound - below_bound).GetAbs() <= margin)
                    return true;

                if (y < target)
                    below_bound = x;
                else if (y > target)
                    above_bound = x;
                else
                    return true;
            }

            return false;
        }
        static public float Solve(float target, float bound_a, float bound_b, Operation<float, float> operation, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            float x;

            TrySolve(target, bound_a, bound_b, operation, out x, margin, max_iterations);
            return x;
        }

        static public IEnumerable<float> SolveAll(float target, float bound_a, float bound_b, Operation<float, float> operation, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS, int max_depth = DEFAULT_SOLVE_ALL_MAX_DEPTH)
        {
            float x;

            if (Mathq.TrySolve(target, bound_a, bound_b, operation, out x, margin, max_iterations))
            {
                if (max_depth >= 1)
                {
                    foreach (float sx in Mathq.TrySolveAll(target, bound_a, x - margin, operation, margin, max_iterations, max_depth - 1))
                        yield return sx;

                    foreach (float sx in Mathq.TrySolveAll(target, x + margin, bound_b, operation, margin, max_iterations, max_depth - 1))
                        yield return sx;
                }

                yield return x;
            }
        }
    }
}