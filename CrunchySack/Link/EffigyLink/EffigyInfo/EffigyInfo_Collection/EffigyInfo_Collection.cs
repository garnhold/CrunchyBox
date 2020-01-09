using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection : EffigyInfo
    {
        public abstract void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values);

        public EffigyInfo_Collection(Type r, Type c) : base(r, c) { }
    }
}