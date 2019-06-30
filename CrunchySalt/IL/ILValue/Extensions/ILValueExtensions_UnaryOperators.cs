using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_UnaryOperators
    {
        static public ILUnaryOperatorInvokation GetILUnaryOperatorInvokation(this ILValue item, UnaryOperatorType type)
        {
            return new ILUnaryOperatorInvokation(type, item);
        }

        static public ILUnaryOperatorInvokation GetILUnaryOperatorInvokationBySymbol(this ILValue item, string symbol)
        {
            return item.GetILUnaryOperatorInvokation(
                UnaryOperatorTypeExtensions.GetUnaryOperatorTypeBySymbol(symbol)
            );
        }

        static public ILUnaryOperatorInvokation GetILUnaryOperatorInvokationByName(this ILValue item, string name)
        {
            return item.GetILUnaryOperatorInvokation(
                UnaryOperatorTypeExtensions.GetUnaryOperatorTypeByName(name)
            );
        }

        static public ILUnaryOperatorInvokation GetILNumericNegated(this ILValue item)
        {
            return item.GetILUnaryOperatorInvokation(UnaryOperatorType.NumericNegate);
        }

        static public ILUnaryOperatorInvokation GetILLogicalNegated(this ILValue item)
        {
            return item.GetILUnaryOperatorInvokation(UnaryOperatorType.LogicalNegate);
        }

        static public ILUnaryOperatorInvokation GetILOnesComplemented(this ILValue item)
        {
            return item.GetILUnaryOperatorInvokation(UnaryOperatorType.OnesComplement);
        }
    }
}