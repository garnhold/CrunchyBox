using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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