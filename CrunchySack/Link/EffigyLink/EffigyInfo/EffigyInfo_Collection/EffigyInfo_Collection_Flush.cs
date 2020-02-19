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
        public abstract void ClearChildren(object representation);

        public EffigyInfo_Collection_Flush(Type r, Type c) : base(r, c) { }

        public override void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values)
        {
            ClearChildren(representation);

            old_values.Process(v => link.UnlinkValue(v));
            new_values.Process(v => AddChild(representation, link.Instance(v)));
        }
    }
}