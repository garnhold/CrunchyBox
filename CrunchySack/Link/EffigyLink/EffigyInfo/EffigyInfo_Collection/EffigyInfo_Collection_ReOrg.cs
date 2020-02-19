using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection_ReOrg : EffigyInfo_Collection
    {
        private AttachedObjectField<object, IDictionary<object, object>> field;

        public abstract void ClearChildren(object representation);

        public EffigyInfo_Collection_ReOrg(Type r, Type c) : base(r, c)
        {
            field = new AttachedObjectField<object, IDictionary<object, object>>(o => new Dictionary<object, object>());
        }

        public override void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values)
        {
            IDictionary<object, object> value_to_sub_representation = field.GetValue(representation);
            HashSet<object> removed_values = value_to_sub_representation.CalculateKeysOnlyIn(new_values);

            ClearChildren(representation);

            foreach (object value in removed_values)
            {
                link.UnlinkValue(value);
                value_to_sub_representation.Remove(value);
            }

            foreach (object value in new_values)
            {
                object sub_representation;

                if (value_to_sub_representation.TryGetValue(value, out sub_representation))
                    AddChild(representation, sub_representation);
                else
                {
                    value_to_sub_representation.Add(value,
                        link.Instance(value).Chain(c => AddChild(representation, c))
                    );
                }
            }
        }
    }
}