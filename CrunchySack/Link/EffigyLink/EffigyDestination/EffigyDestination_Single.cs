using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class EffigyDestination_Single : EffigyDestination
    {
        private EffigyInfo_Single single_info;

        public EffigyDestination_Single(object r, EffigyInfo_Single i) : base(r, i)
        {
            single_info = i;
        }

        public void SetChild(object child)
        {
            single_info.SetChild(GetRepresentation(), child);
        }

        public void Update(EffigyLink link, object old_value, object new_value)
        {
            single_info.Update(link, GetRepresentation(), old_value, new_value);
        }
    }
}