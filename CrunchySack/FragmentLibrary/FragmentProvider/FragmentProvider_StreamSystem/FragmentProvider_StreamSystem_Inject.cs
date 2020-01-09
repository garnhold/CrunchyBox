using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class FragmentProvider_StreamSystem_Inject  : FragmentProvider_StreamSystem
    {
        private string format;

        protected override string CalculateId(string name)
        {
            return format.Inject(name);
        }

        public FragmentProvider_StreamSystem_Inject(StreamSystem s, string f) : base(s)
        {
            format = f;
        }
    }
}