using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyDestination
    {
        private object representation;
        private EffigyInfo info;

        public EffigyDestination(object r, EffigyInfo i)
        {
            representation = r;
            info = i;
        }

        public object GetRepresentation()
        {
            return representation;
        }
    }
}