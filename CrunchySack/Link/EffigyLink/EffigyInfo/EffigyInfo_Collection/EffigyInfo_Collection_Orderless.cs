using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection_Orderless : EffigyInfo_Collection
    {
        public abstract void AddChild(object representation, object child);
        public abstract void RemoveChild(object representation, object child);

        protected override EffigyCollectionDestination CreateCollectionDestination(object representation)
        {
            Dictionary<object, object> value_to_sub_representation = new Dictionary<object, object>();

            return delegate (EffigyLink link, IList<object> old_values, IList<object> new_values) {
                HashSet<object> removed_values;
                HashSet<object> added_values;

                value_to_sub_representation.CalculateKeysOnlyIn(new_values, out removed_values, out added_values);

                foreach (object value in removed_values)
                {
                    link.UnlinkValue(value);
                    RemoveChild(representation, value_to_sub_representation.PopValue(value));
                }

                foreach (object value in added_values)
                {
                    value_to_sub_representation.Add(value,
                        link.LinkValue(value).Chain(c => AddChild(representation, c))
                    );
                }
            };
        }

        public EffigyInfo_Collection_Orderless(Type r, Type c) : base(r, c)
        {
        }

        public override void SetChildren(object representation, IEnumerable<object> children)
        {
            children.Process(c => AddChild(representation, c));
        }
    }
}