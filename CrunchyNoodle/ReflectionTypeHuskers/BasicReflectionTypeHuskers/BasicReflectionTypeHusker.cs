using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public partial class MethodInfoEXHusker : Husker<MethodInfoEX>
    {
		static public readonly MethodInfoEXHusker INSTANCE = new MethodInfoEXHusker();

        private MethodInfoEXHusker() { }

		public override void Dehydrate(HuskWriter writer, MethodInfoEX to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteInt(to_dehydrate.MetadataToken);
				writer.WriteRecurrant(to_dehydrate.Module, ModuleHusker.INSTANCE);
            }
            else
            {
                writer.WriteInt(0);
            }
        }

        public override MethodInfoEX Hydrate(HuskReader reader)
        {
            int metadata_token = reader.ReadInt();

            if (metadata_token != 0)
                return Resolve(reader.ReadRecurrant(ModuleHusker.INSTANCE), metadata_token);

            return null;
        }
    }
	public class MethodInfoEXListHusker : ListHusker<MethodInfoEX>
	{
		static public readonly MethodInfoEXListHusker INSTANCE = new MethodInfoEXListHusker();

		private MethodInfoEXListHusker() : base(MethodInfoEXHusker.INSTANCE) { }
	}

    public partial class FieldInfoEXHusker : Husker<FieldInfoEX>
    {
		static public readonly FieldInfoEXHusker INSTANCE = new FieldInfoEXHusker();

        private FieldInfoEXHusker() { }

		public override void Dehydrate(HuskWriter writer, FieldInfoEX to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteInt(to_dehydrate.MetadataToken);
				writer.WriteRecurrant(to_dehydrate.Module, ModuleHusker.INSTANCE);
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
                return Resolve(reader.ReadRecurrant(ModuleHusker.INSTANCE), metadata_token);

            return null;
        }
    }
	public class FieldInfoEXListHusker : ListHusker<FieldInfoEX>
	{
		static public readonly FieldInfoEXListHusker INSTANCE = new FieldInfoEXListHusker();

		private FieldInfoEXListHusker() : base(FieldInfoEXHusker.INSTANCE) { }
	}

    public partial class TypeHusker : Husker<Type>
    {
		static public readonly TypeHusker INSTANCE = new TypeHusker();

        private TypeHusker() { }

		public override void Dehydrate(HuskWriter writer, Type to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteInt(to_dehydrate.MetadataToken);
				writer.WriteRecurrant(to_dehydrate.Module, ModuleHusker.INSTANCE);
            }
            else
            {
                writer.WriteInt(0);
            }
        }

        public override Type Hydrate(HuskReader reader)
        {
            int metadata_token = reader.ReadInt();

            if (metadata_token != 0)
                return Resolve(reader.ReadRecurrant(ModuleHusker.INSTANCE), metadata_token);

            return null;
        }
    }
	public class TypeListHusker : ListHusker<Type>
	{
		static public readonly TypeListHusker INSTANCE = new TypeListHusker();

		private TypeListHusker() : base(TypeHusker.INSTANCE) { }
	}

}