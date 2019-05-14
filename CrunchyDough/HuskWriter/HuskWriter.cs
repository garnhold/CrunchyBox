using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class HuskWriter
    {
        private BinaryWriter writer;

        private int next_id;
        private Dictionary<object, int> recurrant_objects;

        public HuskWriter(BinaryWriter w)
        {
            writer = w;

            next_id = 0;
            recurrant_objects = new Dictionary<object, int>();
        }

        public HuskWriter(Stream s) : this(new BinaryWriter(s)) { }

        public void WriteHeader(byte[] header) { writer.WriteByteHeader(header); }

        public void WriteBool(bool value) { writer.Write(value); }

        public void WriteByte(byte value) { writer.Write(value); }
        public void WriteShort(short value) { writer.Write(value); }
        public void WriteInt(int value) { writer.Write(value); }
        public void WriteLong(long value) { writer.Write(value); }
        public void WriteFloat(float value) { writer.Write(value); }
        public void WriteDouble(double value) { writer.Write(value); }
        public void WriteDecimal(decimal value) { writer.Write(value); }

        public void WriteString(string value) { writer.Write(value); }

        public void WriteRecurrant<T>(T value, Husker<T> husker)
        {
            int id;

            if (recurrant_objects.TryGetValue(value, out id))
            {
                writer.Write(id);
            }
            else
            {
                id = next_id++;

                writer.Write(id);
                recurrant_objects.Add(value, id);

                husker.Dehydrate(this, value);
            }
        }
    }
}