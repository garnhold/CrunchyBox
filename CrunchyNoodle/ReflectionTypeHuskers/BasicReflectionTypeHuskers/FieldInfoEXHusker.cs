using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class FieldInfoEXHusker : Husker<FieldInfoEX>
    {
        static public readonly FieldInfoEXHusker INSTANCE = new FieldInfoEXHusker();

        private FieldInfoEXHusker() { }

        public override void Dehydrate(HuskWriter writer, FieldInfoEX to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteInt(to_dehydrate.MetadataToken);
                writer.WriteRecurrant(to_dehydrate.DeclaringType, TypeHusker.INSTANCE);
            }
            else
            {
                writer.WriteInt(0);
            }
        }

        public override FieldInfoEX Hydrate(HuskReader reader)
        {
            int metadata_token = reader.ReadInt();

            if (metadata_token != 0)
                return reader.ReadRecurrant(TypeHusker.INSTANCE).ResolveField(metadata_token);

            return null;
        }
    }

    public class FieldInfoEXListHusker : ListHusker<FieldInfoEX>
    {
        static public readonly FieldInfoEXListHusker INSTANCE = new FieldInfoEXListHusker();

        private FieldInfoEXListHusker() : base(FieldInfoEXHusker.INSTANCE) { }
    }
}