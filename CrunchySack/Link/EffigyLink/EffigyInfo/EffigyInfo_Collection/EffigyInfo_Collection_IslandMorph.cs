using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class EffigyInfo_Collection_IslandMorph : EffigyInfo_Collection
    {
        public abstract void RemoveChildAt(object representation, int index);
        public abstract void InsertChild(object representation, int index, object child);

        public EffigyInfo_Collection_IslandMorph(Type r, Type c) : base(r, c) { }

        public override void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values)
        {
            IslandMorphInfo info = old_values.CalculateIslandMorph(new_values);

            for (int i = info.remove_range.start; i < info.remove_range.end; i++)
            {
                link.UnlinkValue(old_values[i]);
                RemoveChildAt(representation, info.remove_range.start);
            }

            new_values.SubSection(info.insert_range).ProcessWithIndex(delegate(int index, object value) {
                link.CreateRepresentationInto(value, delegate(object child) {
                    InsertChild(representation, info.insert_index + index, child);
                });
            });
        }
    }
}