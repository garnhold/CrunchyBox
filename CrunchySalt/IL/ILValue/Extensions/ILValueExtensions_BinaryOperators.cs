using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_BinaryOperators
    {
        static public ILBinaryOperatorInvokation GetILBinaryOperatorInvokation(this ILValue item, BinaryOperatorType type, ILValue right)
        {
            return new ILBinaryOperatorInvokation(type, item, right);
        }

        static public ILBinaryOperatorInvokation GetILMultiplied(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.Multiply, right);
        }
        static public ILBinaryOperatorInvokation GetILDivided(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.Divide, right);
        }
        static public ILBinaryOperatorInvokation GetILModuloed(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.Modulo, right);
        }

        static public ILBinaryOperatorInvokation GetILAdded(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.Add, right);
        }
        static public ILBinaryOperatorInvokation GetILSubtracted(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.Subtract, right);
        }

        static public ILBinaryOperatorInvokation GetILANDed(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.And, right);
        }
        static public ILBinaryOperatorInvokation GetILORed(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.Or, right);
        }

        static public ILBinaryOperatorInvokation GetILEqualTo(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.EqualTo, right);
        }
        static public ILBinaryOperatorInvokation GetILNotEqualTo(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.NotEqualTo, right);
        }

        static public ILBinaryOperatorInvokation GetILLessThan(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.LessThan, right);
        }
        static public ILBinaryOperatorInvokation GetILLessThanOrEqualTo(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.LessThanOrEqualTo, right);
        }

        static public ILBinaryOperatorInvokation GetILGreaterThan(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.GreaterThan, right);
        }
        static public ILBinaryOperatorInvokation GetILGreaterThanOrEqualTo(this ILValue item, ILValue right)
        {
            return item.GetILBinaryOperatorInvokation(BinaryOperatorType.GreaterThanOrEqualTo, right);
        }
    }
}