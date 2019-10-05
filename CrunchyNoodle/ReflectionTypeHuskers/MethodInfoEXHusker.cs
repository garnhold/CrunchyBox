using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class MethodInfoEXHusker : Husker<MethodInfoEX>
    {
        static public readonly MethodInfoEXHusker INSTANCE = new MethodInfoEXHusker();

        private MethodInfoEXHusker() { }

        public override void Dehydrate(HuskWriter writer, MethodInfoEX to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteInt(to_dehydrate.MetadataToken);
                writer.WriteRecurrant(to_dehydrate.DeclaringType, TypeHusker.INSTANCE);

                if (to_dehydrate.IsGenericMethod())
                {
                    if (writer.WriteBoolBranch(to_dehydrate.IsGenericTypedMethod()))
                        TypeListHusker.INSTANCE.Dehydrate(writer, to_dehydrate.GetGenericArguments().ToList());
                }
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
            {
                MethodInfoEX method = reader.ReadRecurrant(TypeHusker.INSTANCE).ResolveMethod(metadata_token);

                if (method.IsGenericMethod())
                {
                    if (reader.ReadBoolBranch())
                    {
                        return method.MakeGenericMethod(TypeListHusker.INSTANCE.Hydrate(reader).ToArray())
                            .GetMethodInfoEX();
                    }
                }

                return method;
            }

            return null;
        }
    }

    public class MethodInfoEXListHusker : ListHusker<MethodInfoEX>
    {
        static public readonly MethodInfoEXListHusker INSTANCE = new MethodInfoEXListHusker();

        private MethodInfoEXListHusker() : base(MethodInfoEXHusker.INSTANCE) { }
    }
}