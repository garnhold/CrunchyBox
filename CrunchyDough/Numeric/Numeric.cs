using System;

namespace Crunchy.Dough
{
    static public class Numeric
    {
        static public byte GetTypePrecedence(Type type)
        {
            if (type.IsNumeric())
            {
                if (type == typeof(byte)) return 1;
                if (type == typeof(short)) return 2;
                if (type == typeof(int)) return 3;
                if (type == typeof(long)) return 4;
                if (type == typeof(float)) return 5;
                if (type == typeof(double)) return 6;
                if (type == typeof(decimal)) return 7;

                throw new UnaccountedBranchException("type", type);
            }

            return 0;
        }

        static public Type GetMostPrecedentType(Type type1, Type type2)
        {
            byte type1_precedence = GetTypePrecedence(type1);
            byte type2_precedence = GetTypePrecedence(type2);

            if(type1_precedence != 0 && type2_precedence != 0)
            {
                if(type1_precedence > type2_precedence)
                    return type1;

                return type2;
            }

            return null;
        }
    }
}