using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class BinaryReaderWriterExtensions_ByteHeader
    {
        static public void WriteByteHeader(this BinaryWriter item, byte[] header)
        {
            item.Write(header);
        }
        static public void WriteByteHeader(this BinaryWriter item, string header)
        {
            item.WriteByteHeader(header.ToUnicodeBytes());
        }

        static public bool VerifyByteHeader(this BinaryReader item, byte[] header)
        {
            byte[] read_header = item.ReadBytes(header.Length);

            if (header.AreElementsEqual(read_header))
                return true;

            return false;
        }
        static public bool VerifyByteHeader(this BinaryReader item, string header)
        {
            return item.VerifyByteHeader(header.ToUnicodeBytes());
        }
    }
}