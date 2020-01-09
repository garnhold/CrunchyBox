using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class PropertyInfoEXHusker : Husker<PropertyInfoEX>
    {
        static public readonly PropertyInfoEXHusker INSTANCE = new PropertyInfoEXHusker();

        private PropertyInfoEXHusker() { }

        public override void Dehydrate(HuskWriter writer, PropertyInfoEX to_dehydrate)
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

        public override PropertyInfoEX Hydrate(HuskReader reader)
        {
            int metadata_token = reader.ReadInt();

            if (metadata_token != 0)
                return reader.ReadRecurrant(TypeHusker.INSTANCE).ResolveProperty(metadata_token);

            return null;
        }
    }

    public class PropertyInfoEXListHusker : ListHusker<PropertyInfoEX>
    {
        static public readonly PropertyInfoEXListHusker INSTANCE = new PropertyInfoEXListHusker();

        private PropertyInfoEXListHusker() : base(PropertyInfoEXHusker.INSTANCE) { }
    }
}