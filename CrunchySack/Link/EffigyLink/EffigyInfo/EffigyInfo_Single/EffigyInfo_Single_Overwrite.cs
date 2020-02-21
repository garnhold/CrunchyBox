using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Single_Overwrite : EffigyInfo_Single
    {
        public override EffigySingleDestination CreateSingleDestination(object representation)
        {
            return delegate (EffigyLink link, object old_value, object new_value) {
                link.UnlinkValue(old_value);

                SetChild(representation, link.Instance(new_value));
            };
        }

        public EffigyInfo_Single_Overwrite(Type r, Type c) : base(r, c) { }
    }
}