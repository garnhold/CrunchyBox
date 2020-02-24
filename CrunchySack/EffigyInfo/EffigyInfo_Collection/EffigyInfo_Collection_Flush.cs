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
        protected override EffigyCollectionDestination CreateCollectionDestination(object representation)
        {
            List<object> new_representations = new List<object>();
            StaleDictionary<object, object> value_to_representation = new StaleDictionary<object, object>();

            return delegate (EffigyLink link, IList<object> old_values, IList<object> new_values) {
                value_to_representation.MarkStale();

                new_representations.Set(
                    new_values.Convert(v => value_to_representation.GetOrCreateValue(v, () => link.LinkValue(v)))
                );

                value_to_representation.RemoveStale(p => link.UnlinkValue(p.Key));

                SetChildren(representation, new_representations);
            };
        }

        public EffigyInfo_Collection_Flush(Type r, Type c) : base(r, c) { }
    }
}