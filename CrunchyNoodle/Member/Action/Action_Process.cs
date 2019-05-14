using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Action_Process : Action
    {
        private string name;
        private Process<object> process;

        protected override void ExecuteInternal(object target)
        {
            process(target);
        }

        protected override string GetActionNameInternal()
        {
            return name;
        }

        public Action_Process(string n, Type d, Process<object> p) : base(d)
        {
            name = n;
            process = p;
        }
    }
}