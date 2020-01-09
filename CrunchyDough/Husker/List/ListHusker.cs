using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ListHusker<T> : Husker<List<T>>
    {
        private Husker<T> husker;

        public ListHusker(Husker<T> h)
        {
            husker = h;
        }

        public override void Dehydrate(HuskWriter writer, List<T> to_dehydrate)
        {
            writer.WriteInt(to_dehydrate.Count);

            to_dehydrate.Process(i => husker.Dehydrate(writer, i));
        }

        public override List<T> Hydrate(HuskReader reader)
        {
            List<T> list = new List<T>();

            int count = reader.ReadInt();

            for (int i = 0; i < count; i++)
                list.Add(husker.Hydrate(reader));

            return list;
        }
    }
}