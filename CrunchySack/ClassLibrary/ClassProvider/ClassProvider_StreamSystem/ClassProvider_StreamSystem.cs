using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class ClassProvider_StreamSystem  : ClassProvider
    {
        private StreamSystem stream_system;

        protected abstract string CalculateId(Type type, string layout);

        protected override CmlClass GetClassInternal(Type type, string layout)
        {
            return stream_system.ReadCmlEntity(CalculateId(type, layout))
                .IfNotNull(c => new CmlClass_Entity(type, layout, c));
        }

        public ClassProvider_StreamSystem(StreamSystem s)
        {
            stream_system = s;
        }
    }
}