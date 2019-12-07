using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class ClassProvider_StreamSystem_Inject : ClassProvider_StreamSystem
    {
        private string format;

        protected override string CalculateId(Type type, string layout)
        {
            return format.Inject(type.Name, layout);
        }

        public ClassProvider_StreamSystem_Inject(StreamSystem s, string f) : base(s)
        {
            format = f;
        }
    }
}