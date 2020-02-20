using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection_Flush : EffigyInfo_Collection
    {
        public EffigyInfo_Collection_Flush(Type r, Type c) : base(r, c) { }

        public override void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values)
        {
            old_values.Process(v => link.UnlinkValue(v));

            SetChildren(representation, new_values.Convert(v => link.Instance(v)));
        }
    }
}