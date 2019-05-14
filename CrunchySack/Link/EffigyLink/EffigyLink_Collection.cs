using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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

        public EffigyLink_Collection(CmlExecution execution, EffigySource_Collection s, EffigyDestination_Collection d, EffigyClassInfo c) : base(execution, s, d, c)
        {
            collection_source = s;
            collection_destination = d;
        }
    }
}