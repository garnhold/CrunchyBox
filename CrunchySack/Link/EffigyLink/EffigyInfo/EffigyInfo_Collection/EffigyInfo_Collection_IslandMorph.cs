using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection_IslandMorph : EffigyInfo_Collection
    {
        public abstract void RemoveChildAt(object representation, int index);
        public abstract void InsertChild(object representation, int index, object child);

        protected override EffigyCollectionDestination CreateCollectionDestination(object representation)
        {
            return delegate (EffigyLink link, IList<object> old_values, IList<object> new_values) {
                IslandMorphInfo info = old_values.CalculateIslandMorph(new_values);

                for (int i = info.remove_range.start; i < info.remove_range.end; i++)
                {
                    link.UnlinkValue(old_values[i]);
                    RemoveChildAt(representation, info.remove_range.start);
                }

                new_values.SubSection(info.insert_range).ProcessWithIndex(
                    (i, v) => InsertChild(representation, info.insert_index + i, link.Instance(v))
                );
            };
        }

        public EffigyInfo_Collection_IslandMorph(Type r, Type c) : base(r, c) { }

        public override void SetChildren(object representation, IEnumerable<object> children)
        {
            children.ProcessWithIndex((i, c) => InsertChild(representation, i, c));
        }
    }
}