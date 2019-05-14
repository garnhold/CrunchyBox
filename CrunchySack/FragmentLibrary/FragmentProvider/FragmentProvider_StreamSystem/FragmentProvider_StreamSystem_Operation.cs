using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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