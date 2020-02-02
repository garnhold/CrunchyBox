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
        public abstract void ClearChildren(object representation);
        public abstract IEnumerable<object> GetChildren(object representation);

        public EffigyInfo_Collection_ReOrg(Type r, Type c) : base(r, c) { }

        public override void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values)
        {
            Dictionary<object, object> old_to_sub_representation = old_values
                .PairPermissive(GetChildren(representation))
                .ConvertToKeyValuePairs()
                .ToDictionary();

            ClearChildren(representation);

            foreach (object value in new_values)
            {
                object sub_representation;

                if (old_to_sub_representation.TryPopValue(value, out sub_representation))
                    AddChild(representation, sub_representation);
                else
                    link.CreateRepresentationInto(value, c => AddChild(representation, c));
            }

            old_to_sub_representation.Keys.Process(v => link.UnlinkValue(v));
        }
    }
}