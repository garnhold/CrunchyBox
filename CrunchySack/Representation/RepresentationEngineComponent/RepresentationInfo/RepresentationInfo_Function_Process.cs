using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Function_Process<REPRESENTATION_TYPE> : RepresentationInfo_Function<REPRESENTATION_TYPE>
    {
        private Process<REPRESENTATION_TYPE, FunctionSyncro> process;

        protected override void ApplyFunctionSyncroToRepresentation(REPRESENTATION_TYPE representation, FunctionSyncro function_syncro)
        {
            process(representation, function_syncro);
        }

        public RepresentationInfo_Function_Process(string n, Process<REPRESENTATION_TYPE, FunctionSyncro> p) : base(n)
        {
            process = p;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddFunctionInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, FunctionSyncro> p)
        {
            item.AddInfo(new RepresentationInfo_Function_Process<REPRESENTATION_TYPE>(n, p));
        }
    }
}