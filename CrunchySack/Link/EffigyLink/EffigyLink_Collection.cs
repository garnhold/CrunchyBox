using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyLink_Collection : EffigyLink
    {
        private EffigySource_Collection collection_source;
        private EffigyDestination_Collection collection_destination;

        protected override void UpdateInternal()
        {
            collection_source.Update(delegate(List<object> old_values, List<object> new_values) {
                collection_destination.Update(this, old_values, new_values);
            });
        }

        public EffigyLink_Collection(CmlContext context, EffigySource_Collection s, EffigyDestination_Collection d, EffigyClassInfo c) : base(context, s, d, c)
        {
            collection_source = s;
            collection_destination = d;
        }
    }
}