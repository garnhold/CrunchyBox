using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public partial class Buffer
        {
            public bool ReadBoolean() { return buffer.ReadBoolean(); }
            public byte ReadByte() { return buffer.ReadByte(); }
            public short ReadInt16() { return buffer.ReadInt16(); }
            public int ReadInt24() { return buffer.ReadInt32(24); }
            public int ReadInt32() { return buffer.ReadInt32(); }
            public long ReadInt64() { return buffer.ReadInt64(); }
            public float ReadSingle() { return buffer.ReadFloat(); }
            public double ReadDouble() { return buffer.ReadDouble(); }
            public string ReadString() { return buffer.ReadString(); }

            public void WriteBoolean(bool value) { buffer.Write(value); }
            public void WriteByte(byte value) { buffer.Write(value); }
            public void WriteInt16(short value) { buffer.Write(value); }
            public void WriteInt24(int value) { buffer.Write(value, 24); }
            public void WriteInt32(int value) { buffer.Write(value); }
            public void WriteInt64(long value) { buffer.Write(value); }
            public void WriteSingle(float value) { buffer.Write(value); }
            public void WriteDouble(double value) { buffer.Write(value); }
            public void WriteString(string value) { buffer.Write(value); }
        }
    }
}