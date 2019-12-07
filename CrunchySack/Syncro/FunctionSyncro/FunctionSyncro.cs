using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class FunctionSyncro
    {
        private FunctionInstance function_instance;

        private SyncroManager manager;

        public FunctionSyncro(FunctionInstance f)
        {
            function_instance = f;
        }

        public void SetManager(SyncroManager m)
        {
            manager = m;
        }

        public void Execute(object[] arguments)
        {
            manager.ExecuteFunction(function_instance, arguments);
        }

        public void Execute()
        {
            Execute(Empty.Array<object>());
        }

        public object GetTarget()
        {
            return function_instance.GetTarget();
        }

        public Function GetFunction()
        {
            return function_instance.GetFunction();
        }
    }
}