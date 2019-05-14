﻿using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class EffigyDestination_Collection : EffigyDestination
    {
        private EffigyInfo_Collection collection_info;

        public EffigyDestination_Collection(object r, EffigyInfo_Collection i) : base(r, i)
        {
            collection_info = i;
        }

        public void AddChild(object child)
        {
            collection_info.AddChild(GetRepresentation(), child);
        }

        public void Update(EffigyLink link, IList<object> old_values, IList<object> new_values)
        {
            collection_info.Update(link, GetRepresentation(), old_values, new_values);
        }
    }
}