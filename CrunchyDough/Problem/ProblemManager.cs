using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public delegate void ProblemRaiser(Type type, Operation<Problem> creator);

    public class ProblemManager
    {
        private ProblemRaiser current_problem_raiser;

        static private ProblemManager INSTANCE;
        static public ProblemManager GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new ProblemManager();

            return INSTANCE;
        }

        private ProblemManager()
        {
            current_problem_raiser = null;
        }

        public void Layer(Process process, ProblemRaiser problem_raiser)
        {
            ProblemRaiser old_problem_raiser = current_problem_raiser;

            try
            {
                current_problem_raiser = problem_raiser;

                process();
            }
            finally
            {
                current_problem_raiser = old_problem_raiser;
            }
        }
        public T Layer<T>(Operation<T> operation, ProblemRaiser problem_raiser)
        {
            T result = default(T);

            Layer(() => result = operation(), problem_raiser);
            return result;
        }

        public void RaiseProblem(Type type, Operation<Problem> creator)
        {
            if (current_problem_raiser != null)
            {
                current_problem_raiser(type, creator);
                current_problem_raiser = null;
            }
        }
    }
}