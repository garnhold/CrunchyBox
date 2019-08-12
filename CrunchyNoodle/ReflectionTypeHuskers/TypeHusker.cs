using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class TypeHusker : Husker<Type>
    {
        static public readonly TypeHusker INSTANCE = new TypeHusker();

        private TypeHusker() { }

        public override void Dehydrate(HuskWriter writer, Type to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteInt(to_dehydrate.MetadataToken);
				writer.WriteRecurrant(to_dehydrate.Module, ModuleHusker.INSTANCE);

                if (to_dehydrate.IsGenericClass())
                {
                    if (writer.WriteBoolBranch(to_dehydrate.IsGenericTypedClass()))
                        TypeListHusker.INSTANCE.Dehydrate(writer, to_dehydrate.GetGenericArguments().ToList());
                }
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
            {
                Type type = reader.ReadRecurrant(ModuleHusker.INSTANCE).ResolveType(metadata_token);

                if (type.IsGenericClass())
                {
                    if (reader.ReadBoolBranch())
                        return type.MakeGenericType(TypeListHusker.INSTANCE.Hydrate(reader).ToArray());
                }

                return type;
            }

            return null;
        }
    }

    public class TypeListHusker : ListHusker<Type>
    {
        static public readonly TypeListHusker INSTANCE = new TypeListHusker();

        private TypeListHusker() : base(TypeHusker.INSTANCE) { }
    }
}