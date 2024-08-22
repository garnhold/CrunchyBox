using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract partial class Problem
    {
        static public void Raise<P1>(Operation<P1> operation) where P1 : Problem
        {
            ProblemManager.GetInstance().RaiseProblem(typeof(P1), () => operation());
        }

        public abstract string GetMessage();

        public Problem()
        {
        }
    }
}