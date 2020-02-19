using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class FragmentProvider_StreamSystem  : FragmentProvider
    {
        private StreamSystem stream_system;

        protected abstract string CalculateId(string name);

        public FragmentProvider_StreamSystem(StreamSystem s)
        {
            stream_system = s;
        }

        public override CmlFragment GetFragment(string name)
        {
            return stream_system.ReadCmlEntity(CalculateId(name))
                .IfNotNull(e => new CmlFragment_Entity(name, e));
        }
    }
}