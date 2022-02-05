using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public partial class Mathq
    {
        static public float FindA(float target, float bound_a, float bound_b, Operation<float, float> operation, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            float x;

            Mathq.TrySolve(target, bound_a, bound_b, operation, out x, margin, max_iterations);
            return x;
        }
        static public IEnumerable<float> FindSome(float target, float bound_a, float bound_b, Operation<float, float> operation, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Floats.Line(bound_a, bound_b, divisions, true)
                .ConvertConnections()
                .TryConvert((Tuple<float, float> t, out float x) => Mathq.TrySolve(target, t.item1, t.item2, operation, out x, margin, max_iterations));
        }


        static public float FindAnEdge(float bound_a, float bound_b, Predicate<float> predicate, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            float x;

            Mathq.TrySolveEdge(bound_a, bound_b, predicate, out x, margin, max_iterations);
            return x;
        }
        static public IEnumerable<float> FindSomeEdges(float bound_a, float bound_b, Predicate<float> predicate, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.FindSome(0.0f, bound_a, bound_b, x => predicate(x).ConvertBool(1.0f, -1.0f), divisions, margin, max_iterations);
        }

        static public IEnumerable<float> FindSomeExtrimi(float bound_a, float bound_b, Operation<float, float> function, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            Operation<float, float> derivative = Mathq.GetDerivative(function);

            return Mathq.FindSomeEdges(bound_a, bound_b, x => derivative(x) > 0.0f, divisions, margin, max_iterations);
        }

        static public float FindAMaximum(float bound_a, float bound_b, Operation<float, float> function, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.FindSomeExtrimi(bound_a, bound_b, function, divisions, margin, max_iterations)
                .Append(bound_a, bound_b)
                .FindHighestRated(x => function(x));
        }

        static public float FindAMinimum(float bound_a, float bound_b, Operation<float, float> function, int divisions = DEFAULT_MULTI_SOLVE_DIVISIONS, float margin = DEFAULT_SOLVE_MARGIN, int max_iterations = DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Mathq.FindSomeExtrimi(bound_a, bound_b, function, divisions, margin, max_iterations)
                .Append(bound_a, bound_b)
                .FindLowestRated(x => function(x));
        }
    }
}