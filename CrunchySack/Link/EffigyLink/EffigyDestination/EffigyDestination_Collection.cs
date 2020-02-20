using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyDestination_Collection : EffigyDestination
    {
        private EffigyInfo_Collection collection_info;

        public EffigyDestination_Collection(object r, EffigyInfo_Collection i) : base(r, i)
        {
            collection_info = i;
        }

        public void Update(EffigyLink link, IList<object> old_values, IList<object> new_values)
        {
            collection_info.Update(link, GetRepresentation(), old_values, new_values);
        }
    }
}