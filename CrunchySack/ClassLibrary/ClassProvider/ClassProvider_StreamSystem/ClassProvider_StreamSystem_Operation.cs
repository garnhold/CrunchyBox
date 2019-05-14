using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class ClassProvider_StreamSystem_Operation  : ClassProvider_StreamSystem
    {
        private Operation<string, Type, string> operation;

        protected override string CalculateId(Type type, string layout)
        {
            return operation(type, layout);
        }

        public ClassProvider_StreamSystem_Operation(StreamSystem s, Operation<string, Type, string> o) : base(s)
        {
            operation = o;
        }
    }
}