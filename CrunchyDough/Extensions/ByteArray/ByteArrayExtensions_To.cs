using System;

namespace Crunchy.Dough
{
    static public class ByteArrayExtensions_To
    {
        static public string ToBase64String(this byte[] item)
        {
            if(item != null)
                return Convert.ToBase64String(item);

            return "";
        }

        static public string ToHexString(this byte[] item)
        {
            return item.Convert(b => b.ToHex()).Join();
        }

        static public string ToBinaryRepresentationString(this byte[] item, BinaryRepresentationType type)
        {
            switch (type)
            {
                case BinaryRepresentationType.Base64:
                    return item.ToBase64String();

                case BinaryRepresentationType.Hex:
                    return item.ToHexString();
            }

            throw new UnaccountedBranchException("type", type);
        }
    }
}