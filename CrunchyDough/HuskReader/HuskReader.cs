using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class HuskReader
    {
        private BinaryReader reader;

        private List<object> recurrant_objects;

        public HuskReader(BinaryReader r)
        {
            reader = r;

            recurrant_objects = new List<object>();
        }

        public HuskReader(Stream s) : this(new BinaryReader(s)) { }

        public bool VerifyHeader(byte[] header) { return reader.VerifyByteHeader(header); }

        public bool ReadBool() { return reader.ReadBoolean(); }

        public byte ReadByte() { return reader.ReadByte(); }
        public short ReadShort() { return reader.ReadInt16(); }
        public int ReadInt() { return reader.ReadInt32(); }
        public long ReadLong() { return reader.ReadInt64(); }
        public float ReadFloat() { return reader.ReadSingle(); }
        public double ReadDouble() { return reader.ReadDouble(); }
        public decimal ReadDecimal() { return reader.ReadDecimal(); }

        public string ReadString() { return reader.ReadString(); }

        public bool ReadBoolBranch()
        {
            return ReadBool();
        }

        public T ReadRecurrant<T>(Husker<T> husker)
        {
            int id = reader.ReadInt32();

            if (id < recurrant_objects.Count)
                return recurrant_objects[id].Convert<T>();

            recurrant_objects.Add(null);
            T value = husker.Hydrate(this);

            recurrant_objects[id] = value;
            return value;
        }
    }
}