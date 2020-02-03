using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    using Salt;
    
    static public class ILCastInfos
    {
        static private OperationCache<ILCastInfo, Type, Type, bool, bool, bool> GET_IL_CAST_INFO = ReflectionCache.Get().NewOperationCache<ILCastInfo, Type, Type, bool, bool, bool>("GET_IL_CAST_INFO", delegate(Type source_type, Type destination_type, bool copy_on_unbox, bool allow_implicit_operators, bool allow_explicit_operators) {
            if (source_type.CanILTreatAs(destination_type))
                return new ILCastInfo_Nothing(source_type, destination_type);

            if (source_type.IsVoidType())
                return new ILCastInfo_LoadDefault(source_type, destination_type);

            if (source_type.IsPointer && source_type.GetElementType() == destination_type)
                return new ILCastInfo_UnmakePointer(source_type, destination_type);

            if (destination_type.IsPointer && source_type == destination_type.GetElementType())
                return new ILCastInfo_MakePointer(source_type, destination_type);

            if (source_type.IsValueType() && destination_type == typeof(object))
                return new ILCastInfo_Box(source_type, destination_type);

            if (source_type.IsNumeric())
            {
                switch (destination_type.GetBasicType())
                {
                    case BasicType.SByte: return new ILCastInfo_Conv_I1(source_type);
                    case BasicType.Short: return new ILCastInfo_Conv_I2(source_type);
                    case BasicType.Int: return new ILCastInfo_Conv_I4(source_type);
                    case BasicType.Long: return new ILCastInfo_Conv_I8(source_type);

                    case BasicType.Byte: return new ILCastInfo_Conv_U1(source_type);
                    case BasicType.UShort: return new ILCastInfo_Conv_U2(source_type);
                    case BasicType.UInt: return new ILCastInfo_Conv_U4(source_type);
                    case BasicType.ULong: return new ILCastInfo_Conv_U8(source_type);

                    case BasicType.Float: return new ILCastInfo_Conv_R4(source_type);
                    case BasicType.Double: return new ILCastInfo_Conv_R8(source_type);
                }
            }

            if (source_type == typeof(object) && destination_type.IsPointer && destination_type.GetElementType().IsValueType())
            {
                if (copy_on_unbox)
                    return new ILCastInfo_UnboxCopyPointer(source_type, destination_type);

                return new ILCastInfo_UnboxPointer(source_type, destination_type);
            }

            if (source_type == typeof(object) && destination_type.IsValueType())
                return new ILCastInfo_UnboxCopy(source_type, destination_type);

            if (source_type.IsRelated(destination_type))
                return new ILCastInfo_CastClass(source_type, destination_type);

            if(allow_implicit_operators)
            {
                MethodInfo method = source_type.GetImplicitConversionMethod(destination_type);

                if (method != null)
                    return new ILCastInfo_ConversionMethod(source_type, destination_type, method);
            }

            if (allow_explicit_operators)
            {
                MethodInfo method = source_type.GetExplicitConversionMethod(destination_type);

                if (method != null)
                    return new ILCastInfo_ConversionMethod(source_type, destination_type, method);
            }

            throw new InvalidOperationException(source_type + " cannot be cast to " + destination_type);
        });
        static public ILCastInfo GetILCastInfo(Type source_type, Type destination_type, bool copy_on_unbox, bool allow_implicit_operators, bool allow_explicit_operators)
        {
            return GET_IL_CAST_INFO.Fetch(source_type, destination_type, copy_on_unbox, allow_implicit_operators, allow_explicit_operators);
        }

        static private OperationCache<ILCastInfo, Type, Type> GET_THIN_IL_CAST_INFO = ReflectionCache.Get().NewOperationCache("GET_THIN_IL_CAST_INFO", delegate(Type source_type, Type destination_type) {
            return GetILCastInfo(source_type, destination_type, false, false, false);
        });
        static public ILCastInfo GetThinILCastInfo(Type source_type, Type destination_type)
        {
            return GET_THIN_IL_CAST_INFO.Fetch(source_type, destination_type);
        }

        static private OperationCache<ILCastInfo, Type, Type> GET_IMPLICIT_IL_CAST_INFO = ReflectionCache.Get().NewOperationCache("GET_IMPLICIT_IL_CAST_INFO", delegate(Type source_type, Type destination_type) {
            return GetILCastInfo(source_type, destination_type, true, true, false);
        });
        static public ILCastInfo GetImplicitILCastInfo(Type source_type, Type destination_type)
        {
            return GET_IMPLICIT_IL_CAST_INFO.Fetch(source_type, destination_type);
        }

        static private OperationCache<ILCastInfo, Type, Type> GET_EXPLICIT_IL_CAST_INFO = ReflectionCache.Get().NewOperationCache("GET_EXPLICIT_IL_CAST_INFO", delegate(Type source_type, Type destination_type) {
            return GetILCastInfo(source_type, destination_type, true, true, true);
        });
        static public ILCastInfo GetExplicitILCastInfo(Type source_type, Type destination_type)
        {
            return GET_EXPLICIT_IL_CAST_INFO.Fetch(source_type, destination_type);
        }
    }
}