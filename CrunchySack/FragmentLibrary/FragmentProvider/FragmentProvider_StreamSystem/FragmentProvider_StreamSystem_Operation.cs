using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class FragmentProvider_StreamSystem_Operation  : FragmentProvider_StreamSystem
    {
        private Operation<string, string> operation;

        protected override string CalculateId(string name)
        {
            return operation(name);
        }

        public FragmentProvider_StreamSystem_Operation(StreamSystem s, Operation<string, string> o) : base(s)
        {
            operation = o;
        }
    }
}