using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class RepresentationInfo_Attribute_Function_Process<REPRESENTATION_TYPE> : RepresentationInfo_Attribute_Function<REPRESENTATION_TYPE>
    {
        private Process<REPRESENTATION_TYPE, FunctionSyncro> process;

        protected override void ApplyFunctionSyncroToRepresentation(REPRESENTATION_TYPE representation, FunctionSyncro function_syncro)
        {
            process(representation, function_syncro);
        }

        public RepresentationInfo_Attribute_Function_Process(string n, Process<REPRESENTATION_TYPE, FunctionSyncro> p) : base(n)
        {
            process = p;
        }
    }
}