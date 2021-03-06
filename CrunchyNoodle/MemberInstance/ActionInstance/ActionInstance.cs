using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class ActionInstance : MemberInstance
    {
        private Action action;

        public ActionInstance(TargetInstance t, Action a) : base(t)
        {
            action = a;
        }

        public void Execute()
        {
            action.Execute(GetTarget());
        }

        public override string ToString()
        {
            return GetTargetInstance() + " -> " + action;
        }
    }

}