using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Convert
    {
        static private CompileTimeCache<MethodInfoEX, IdentifiableType, IdentifiableType> GET_CONVERSION_METHOD = ReflectionCache.Get().NewCompileTimeCache("GET_CONVERSION_METHOD", MethodInfoEXHusker.INSTANCE, delegate(IdentifiableType item, IdentifiableType type) {
            IEnumerable<Filterer<MethodInfo>> filters = new Filterer<MethodInfo>[] {
                Filterer_MethodInfo.CanReturnInto(type),
                Filterer_MethodInfo.CanEffectiveParametersHold(item)
            };

            //TODO: might want to do the whole adjust filter shit so that it has purely static or instance method

            return MarkedMethods<ConversionAttribute>.GetFilteredMarkedStaticMethods(filters).GetFirst() ??
                item.GetValue().GetFilteredStaticMethods(filters.Append(Filterer_MethodInfo.IsNamed("op_Implicit"))).GetFirst() ??
                type.GetValue().GetFilteredStaticMethods(filters.Append(Filterer_MethodInfo.IsNamed("op_Implicit"))).GetFirst() ??
                item.GetValue().GetFilteredStaticMethods(filters.Append(Filterer_MethodInfo.IsNamed("op_Explicit"))).GetFirst() ??
                type.GetValue().GetFilteredStaticMethods(filters.Append(Filterer_MethodInfo.IsNamed("op_Explicit"))).GetFirst();
        });
        static public MethodInfoEX GetConversionMethod(this Type item, Type type)
        {
            return GET_CONVERSION_METHOD.Fetch(item, type);
        }
        static public BasicConversionInvoker GetConversionConversionInvoker(this Type item, Type type)
        {
            return item.GetConversionMethod(type).IfNotNull(m => m.GetBasicConversionInvoker());
        }

        static private OperationCache<ConstructorInfoEX, Type, Type> GET_CONVERSION_CONSTRUCTOR = ReflectionCache.Get().NewOperationCache("GET_CONVERSION_CONSTRUCTOR", delegate(Type item, Type type) {
            return type.GetInstanceConstructor(new Type[]{item});
        });
        static public ConstructorInfoEX GetConversionConstructor(this Type item, Type type)
        {
            return GET_CONVERSION_CONSTRUCTOR.Fetch(item, type);
        }
        static public BasicConversionInvoker GetConversionConstructorInvoker(this Type item, Type type)
        {
            return item.GetConversionConstructor(type).IfNotNull(c => c.GetBasicConversionInvoker());
        }

        static private OperationCache<MethodInfoEX, Type, Type> GET_GENERAL_CONVERSION_METHOD = ReflectionCache.Get().NewOperationCache("GET_GENERAL_CONVERSION_METHOD", delegate(Type item, Type type) {
            return MarkedMethods<ConversionAttribute>.GetFilteredMarkedStaticMethods(
                Filterer_MethodInfo.CouldMaybeReturnInto(type),
                Filterer_MethodInfo.CanEffectiveParametersHold(item, typeof(Type))
            ).GetFirst();
        });
        static public MethodInfoEX GetGeneralConversionMethod(this Type item, Type type)
        {
            return GET_GENERAL_CONVERSION_METHOD.Fetch(item, type);
        }
        static public BasicConversionInvoker GetGeneralConversionMethodInvoker(this Type item, Type type)
        {
            return item.GetGeneralConversionMethod(type).IfNotNull(m => (BasicConversionInvoker)delegate(object obj) {
                return m.Invoke(null, new object[] { obj, type });
            });
        }

        static private OperationCache<BasicConversionInvoker, Type, Type> GET_CONVERSION_INVOKER = ReflectionCache.Get().NewOperationCache("GET_CONVERSION_INVOKER", delegate(Type item, Type type) {
            return item.GetConversionConversionInvoker(type) ??
                item.GetConversionConstructorInvoker(type) ??
                item.GetGeneralConversionMethodInvoker(type);
        });
        static public BasicConversionInvoker GetConversionInvoker(this Type item, Type type)
        {
            return GET_CONVERSION_INVOKER.Fetch(item, type);
        }
    }
}