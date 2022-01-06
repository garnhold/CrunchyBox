using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Default
    {
        static public object GetDefaultValue(this Type item)
        {
            BasicType type = item.GetBasicType();

            switch (type)
            {
                case BasicType.None: return null;

                case BasicType.Void: return null;

                case BasicType.Bool: return (bool)false;

                case BasicType.SByte: return (sbyte)0;
                case BasicType.Short: return (short)0;
                case BasicType.Int: return (int)0;
                case BasicType.Long: return (long)0;

                case BasicType.Byte: return (byte)0;
                case BasicType.UShort: return (ushort)0;
                case BasicType.UInt: return (uint)0;
                case BasicType.ULong: return (ulong)0;

                case BasicType.Float: return (float)0.0f;
                case BasicType.Double: return (double)0.0;
                case BasicType.Decimal: return (decimal)0.0m;

                case BasicType.Char: return (char)0;
                case BasicType.String: return (string)null;

                case BasicType.Array: return null;

                case BasicType.Enum: return item.GetEnumValueByLongValue(0);
                case BasicType.Struct: return item.CreateInstance();
                case BasicType.Class: return null;
            }

            throw new UnaccountedBranchException("type", type);
        }

        static public object CreateBlankValue(this Type item)
        {
            BasicType type = item.GetBasicType();

            switch (type)
            {
                case BasicType.None: return null;

                case BasicType.Void: return null;

                case BasicType.Bool: return (bool)false;

                case BasicType.SByte: return (sbyte)0;
                case BasicType.Short: return (short)0;
                case BasicType.Int: return (int)0;
                case BasicType.Long: return (long)0;

                case BasicType.Byte: return (byte)0;
                case BasicType.UShort: return (ushort)0;
                case BasicType.UInt: return (uint)0;
                case BasicType.ULong: return (ulong)0;

                case BasicType.Float: return (float)0.0f;
                case BasicType.Double: return (double)0.0;
                case BasicType.Decimal: return (decimal)0.0m;

                case BasicType.Char: return (char)0;
                case BasicType.String: return (string)"";

                case BasicType.Array: return item.CreateInstance(0);

                case BasicType.Enum: return item.GetEnumValueByLongValue(0);
                case BasicType.Struct: return item.CreateInstance();
                case BasicType.Class: return item.CreateInstance();
            }

            throw new UnaccountedBranchException("type", type);
        }
    }
}