using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public partial class Mathq
    {
        public const float DEFAULT_SOLVE_MARGIN = 1e-5f;
        public const int DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS = 1024;

        public const int DEFAULT_MULTI_SOLVE_DIVISIONS = 100;

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

        static public bool TrySolveEdge(float bound_a, float bound_b, Predicate<float> predicate, out float x, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.TrySolve(0.0f, bound_a, bound_b, z => predicate(z).ConvertBool(1.0f, -1.0f), out x, margin, max_iterations);
        }
    }
}