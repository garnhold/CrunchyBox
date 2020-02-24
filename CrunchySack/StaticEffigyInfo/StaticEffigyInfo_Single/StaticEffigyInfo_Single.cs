using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class StaticEffigyInfo_Single : StaticEffigyInfo
    {
        public abstract void SetChild(object representation, object child);

        public StaticEffigyInfo_Single(Type r, Type c) : base(r, c) { }

        public override void AddChild(object representation, object child)
        {
            SetChild(representation, child);
        }
    }
}