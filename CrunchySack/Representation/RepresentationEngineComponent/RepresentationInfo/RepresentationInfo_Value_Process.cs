using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Value_Process<REPRESENTATION_TYPE, VALUE_TYPE> : RepresentationInfo_Value
    {
        private Process<REPRESENTATION_TYPE, VALUE_TYPE> process;

        private bool PushToRepresentation(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            REPRESENTATION_TYPE cast;

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                process(cast, value.GetSystemValue().ConvertEX<VALUE_TYPE>());

            return true;
        }

        public RepresentationInfo_Value_Process(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> p) : base(n, typeof(REPRESENTATION_TYPE))
        {
            process = p;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddValueInfo<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> p)
        {
            item.AddInfo(
                new RepresentationInfo_Value_Process<REPRESENTATION_TYPE, VALUE_TYPE>(n, p)
            );
        }
    }
}