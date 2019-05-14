using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public partial class PropInfoEXHusker : Husker<PropInfoEX>
    {
        static public readonly PropInfoEXHusker INSTANCE = new PropInfoEXHusker();

        private PropInfoEXHusker() { }

        private void DehydrateAsField(HuskWriter writer, PropInfoEX_Field to_dehydrate)
        {
            FieldInfoEXHusker.INSTANCE.Dehydrate(writer, to_dehydrate.GetFieldInfo());
        }
        private PropInfoEX HydrateAsField(HuskReader reader)
        {
            FieldInfoEX field = FieldInfoEXHusker.INSTANCE.Hydrate(reader);

            return new PropInfoEX_Field(field);
        }

        private void DehydrateAsMethodPair(HuskWriter writer, PropInfoEX_MethodPair to_dehydrate)
        {
            MethodInfoEXHusker.INSTANCE.Dehydrate(writer, to_dehydrate.GetSetMethodInfo());
            MethodInfoEXHusker.INSTANCE.Dehydrate(writer, to_dehydrate.GetGetMethodInfo());
        }
        private PropInfoEX HydrateAsMethodPair(HuskReader reader)
        {
            MethodInfoEX set_method = MethodInfoEXHusker.INSTANCE.Hydrate(reader);
            MethodInfoEX get_method = MethodInfoEXHusker.INSTANCE.Hydrate(reader);

            return new PropInfoEX_MethodPair(set_method, get_method);
        }

        public override void Dehydrate(HuskWriter writer, PropInfoEX to_dehydrate)
        {
            PropInfoEX_Field field_cast;
            PropInfoEX_MethodPair method_pair_cast;

            if (to_dehydrate.Convert<PropInfoEX_Field>(out field_cast))
            {
                writer.WriteByte(1);
                DehydrateAsField(writer, field_cast);
            }
            else if (to_dehydrate.Convert<PropInfoEX_MethodPair>(out method_pair_cast))
            {
                writer.WriteByte(2);
                DehydrateAsMethodPair(writer, method_pair_cast);
            }
            else
            {
                writer.WriteByte(0);
            }
        }

        public override PropInfoEX Hydrate(HuskReader reader)
        {
            byte type_token = reader.ReadByte();

            switch (type_token)
            {
                case 1: return HydrateAsField(reader);
                case 2: return HydrateAsMethodPair(reader);
            }

            return null;
        }
    }
    public class PropInfoEXListHusker : ListHusker<PropInfoEX>
    {
        static public readonly PropInfoEXListHusker INSTANCE = new PropInfoEXListHusker();

        private PropInfoEXListHusker() : base(PropInfoEXHusker.INSTANCE) { }
    }
}