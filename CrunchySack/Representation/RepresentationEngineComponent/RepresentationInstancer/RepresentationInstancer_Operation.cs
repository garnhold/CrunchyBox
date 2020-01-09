using System;

namespace Crunchy.Sack
{
    using Dough;
    
    public class RepresentationInstancer_Operation : RepresentationInstancer
    {
        private Operation<object> operation;

        public RepresentationInstancer_Operation(string t, Operation<object> o) : base(t)
        {
            operation = o;
        }

        public override object Instance(CmlExecution execution)
        {
 	        return operation();
        }
    }

    public class RepresentationInstancer_Operation<REQUESTER_TYPE> : RepresentationInstancer
    {
        private Operation<object, REQUESTER_TYPE> operation;

        public RepresentationInstancer_Operation(string t, Operation<object, REQUESTER_TYPE> o) : base(t)
        {
            operation = o;
        }

        public override object Instance(CmlExecution execution)
        {
            return operation(execution.GetTargetInfo().GetRequester().Convert<REQUESTER_TYPE>());
        }
    }
}