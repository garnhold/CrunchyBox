using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        public partial class Buffer
        {
            public Enum ReadEnum(Type type)
            {
                return type.MakeEnumValue(buffer.ReadInt64(type.GetEnumInfo().GetMinimumBitage()));
            }
            public T ReadEnum<T>()
            {
                return ReadEnum(typeof(T)).Convert<T>();
            }

            public void WriteEnum(Enum value)
            {
                buffer.Write(value.GetLongValue(), value.GetEnumInfo().GetMinimumBitage());
            }
            public void WriteEnum<T>(T value)
            {
                WriteEnum(value.Convert<Enum>());
            }
        }
    }
}