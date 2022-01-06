using System;

namespace Crunchy.Dough
{
    static public class BasicTypeExtensions_Treatment
    {
        static public bool IsNumeric(this BasicType item)
        {
            switch (item)
            {
                case BasicType.None: return false;

                case BasicType.Void: return false;

                case BasicType.Bool: return false;

                case BasicType.SByte: return true;
                case BasicType.Short: return true;
                case BasicType.Int: return true;
                case BasicType.Long: return true;

                case BasicType.Byte: return true;
                case BasicType.UShort: return true;
                case BasicType.UInt: return true;
                case BasicType.ULong: return true;

                case BasicType.Float: return true;
                case BasicType.Double: return true;
                case BasicType.Decimal: return true;

                case BasicType.Char: return false;
                case BasicType.String: return false;

                case BasicType.Array: return false;

                case BasicType.Class: return false;
                case BasicType.Enum: return false;
                case BasicType.Struct: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsInteger(this BasicType item)
        {
            switch (item)
            {
                case BasicType.None: return false;

                case BasicType.Void: return false;

                case BasicType.Bool: return false;

                case BasicType.SByte: return true;
                case BasicType.Short: return true;
                case BasicType.Int: return true;
                case BasicType.Long: return true;

                case BasicType.Byte: return true;
                case BasicType.UShort: return true;
                case BasicType.UInt: return true;
                case BasicType.ULong: return true;

                case BasicType.Float: return false;
                case BasicType.Double: return false;
                case BasicType.Decimal: return false;

                case BasicType.Char: return false;
                case BasicType.String: return false;

                case BasicType.Array: return false;

                case BasicType.Class: return false;
                case BasicType.Enum: return false;
                case BasicType.Struct: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsSignedInteger(this BasicType item)
        {
            switch (item)
            {
                case BasicType.None: return false;

                case BasicType.Void: return false;

                case BasicType.Bool: return false;

                case BasicType.SByte: return true;
                case BasicType.Short: return true;
                case BasicType.Int: return true;
                case BasicType.Long: return true;

                case BasicType.Byte: return false;
                case BasicType.UShort: return false;
                case BasicType.UInt: return false;
                case BasicType.ULong: return false;

                case BasicType.Float: return false;
                case BasicType.Double: return false;
                case BasicType.Decimal: return false;

                case BasicType.Char: return false;
                case BasicType.String: return false;

                case BasicType.Array: return false;

                case BasicType.Class: return false;
                case BasicType.Enum: return false;
                case BasicType.Struct: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsUnsignedInteger(this BasicType item)
        {
            switch (item)
            {
                case BasicType.None: return false;

                case BasicType.Void: return false;

                case BasicType.Bool: return false;

                case BasicType.SByte: return false;
                case BasicType.Short: return false;
                case BasicType.Int: return false;
                case BasicType.Long: return false;

                case BasicType.Byte: return true;
                case BasicType.UShort: return true;
                case BasicType.UInt: return true;
                case BasicType.ULong: return true;

                case BasicType.Float: return false;
                case BasicType.Double: return false;
                case BasicType.Decimal: return false;

                case BasicType.Char: return false;
                case BasicType.String: return false;

                case BasicType.Array: return false;

                case BasicType.Class: return false;
                case BasicType.Enum: return false;
                case BasicType.Struct: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsReal(this BasicType item)
        {
            switch (item)
            {
                case BasicType.None: return false;

                case BasicType.Void: return false;

                case BasicType.Bool: return false;

                case BasicType.SByte: return false;
                case BasicType.Short: return false;
                case BasicType.Int: return false;
                case BasicType.Long: return false;

                case BasicType.Byte: return false;
                case BasicType.UShort: return false;
                case BasicType.UInt: return false;
                case BasicType.ULong: return false;

                case BasicType.Float: return true;
                case BasicType.Double: return true;
                case BasicType.Decimal: return true;

                case BasicType.Char: return false;
                case BasicType.String: return false;

                case BasicType.Array: return false;

                case BasicType.Class: return false;
                case BasicType.Enum: return false;
                case BasicType.Struct: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsPrimitive(this BasicType item)
        {
            switch (item)
            {
                case BasicType.None: return false;

                case BasicType.Void: return false;

                case BasicType.Bool: return true;

                case BasicType.SByte: return true;
                case BasicType.Short: return true;
                case BasicType.Int: return true;
                case BasicType.Long: return true;

                case BasicType.Byte: return true;
                case BasicType.UShort: return true;
                case BasicType.UInt: return true;
                case BasicType.ULong: return true;

                case BasicType.Float: return true;
                case BasicType.Double: return true;
                case BasicType.Decimal: return true;

                case BasicType.Char: return true;
                case BasicType.String: return true;

                case BasicType.Array: return false;

                case BasicType.Class: return false;
                case BasicType.Enum: return true;
                case BasicType.Struct: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}