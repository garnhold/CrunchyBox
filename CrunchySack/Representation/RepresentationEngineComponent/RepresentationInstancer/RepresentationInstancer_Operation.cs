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

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddSimpleInstancer(this RepresentationEngine item, string t, Operation<object> o)
        {
            item.AddInstancer(
                new RepresentationInstancer_Operation(t, o)
            );
        }

        static public void AddSimpleInstancer(this RepresentationEngine item, string t, Type type)
        {
            item.AddSimpleInstancer(t, () => type.CreateInstance());
        }
        static public void AddSimpleInstancer<REPRESENTATION_TYPE>(this RepresentationEngine item, string t)
        {
            item.AddSimpleInstancer(t, typeof(REPRESENTATION_TYPE));
        }

        static public void AddSimpleInstancer(this RepresentationEngine item, Type type)
        {
            item.AddSimpleInstancer(type.Name, type);
        }
        static public void AddSimpleInstancer<REPRESENTATION_TYPE>(this RepresentationEngine item)
        {
            item.AddSimpleInstancer(typeof(REPRESENTATION_TYPE));
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
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddSimpleInstancer<REQUESTER_TYPE>(this RepresentationEngine item, string t, Operation<object, REQUESTER_TYPE> o)
        {
            item.AddInstancer(
                new RepresentationInstancer_Operation<REQUESTER_TYPE>(t, o)
            );
        }
    }
}