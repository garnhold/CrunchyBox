using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Value_Process<REPRESENTATION_TYPE, VALUE_TYPE> : RepresentationInfo_Attribute_Value
    {
        private Process<REPRESENTATION_TYPE, VALUE_TYPE> process;

        public RepresentationInfo_Attribute_Value_Process(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> p) : base(n, typeof(REPRESENTATION_TYPE))
        {
            process = p;
        }

        public override void SetRepresentationValue(object representation, object value)
        {
            REPRESENTATION_TYPE cast;

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                process(cast, value.ConvertEX<VALUE_TYPE>());
        }
    }
}