using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class EffigyInfo_Single_Overwrite : EffigyInfo_Single
    {
        public EffigyInfo_Single_Overwrite(Type r, Type c) : base(r, c) { }

        public override void Update(EffigyLink link, object representation, object old_value, object new_value)
        {
            link.UnlinkValue(old_value);
            link.CreateRepresentationInto(new_value, delegate(object child) {
                SetChild(representation, child);
            });
        }
    }
}