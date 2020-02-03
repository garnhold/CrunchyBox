using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_IndexerInfoEX
    {
        static private OperationCache<MethodInfoEX, Type, Type> GET_INDEXER_SET_METHOD = ReflectionCache.Get().NewOperationCache("GET_INDEXER_SET_METHOD", delegate(Type target_type, Type index_type) {
            return target_type.GetTechnicalInstanceMethods()
                .Narrow(m => m.Name == "set_Item")
                .Narrow(m => m.CanEffectiveParameterHold(0, index_type))
                .GetFirst();
        });
        static public MethodInfoEX GetIndexerSetMethod(this Type item, Type index_type)
        {
            return GET_INDEXER_SET_METHOD.Fetch(item, index_type);
        }

        static private OperationCache<MethodInfoEX, Type, Type> GET_INDEXER_GET_METHOD = ReflectionCache.Get().NewOperationCache("GET_INDEXER_GET_METHOD", delegate(Type target_type, Type index_type) {
            return target_type.GetTechnicalInstanceMethods()
                .Narrow(m => m.Name == "get_Item")
                .Narrow(m => m.CanEffectiveParameterHold(0, index_type))
                .GetFirst();
        });
        static public MethodInfoEX GetIndexerGetMethod(this Type item, Type index_type)
        {
            return GET_INDEXER_GET_METHOD.Fetch(item, index_type);
        }

        static private OperationCache<IndexerInfoEX, Type, Type> GET_INDEXER = ReflectionCache.Get().NewOperationCache<IndexerInfoEX, Type, Type>("GET_INDEXER", delegate(Type target_type, Type index_type) {
            if (target_type.IsArray)
            {
                Type element_type = target_type.GetElementType();
                BasicType element_basic_type = element_type.GetBasicType();

                switch (element_basic_type)
                {
                    case BasicType.SByte: return IndexerInfoEX_Array_SByte.INSTANCE;
                    case BasicType.Short: return IndexerInfoEX_Array_Short.INSTANCE;
                    case BasicType.Int: return IndexerInfoEX_Array_Int.INSTANCE;
                    case BasicType.Long: return IndexerInfoEX_Array_Long.INSTANCE;

                    case BasicType.Byte: return IndexerInfoEX_Array_Byte.INSTANCE;
                    case BasicType.UShort: return IndexerInfoEX_Array_UShort.INSTANCE;
                    case BasicType.UInt: return IndexerInfoEX_Array_UInt.INSTANCE;
                    case BasicType.ULong: return IndexerInfoEX_Array_ULong.INSTANCE;

                    case BasicType.Float: return IndexerInfoEX_Array_Float.INSTANCE;
                    case BasicType.Double: return IndexerInfoEX_Array_Double.INSTANCE;

                    case BasicType.Array: return new IndexerInfoEX_Array_Reference(element_type);

                    case BasicType.Struct: return new IndexerInfoEX_Array_Struct(element_type);
                    case BasicType.Class: return new IndexerInfoEX_Array_Reference(element_type);
                }

                throw new UnaccountedBranchException("element_basic_type", element_basic_type);
            }
            else
            {
                MethodInfoEX set_method = target_type.GetIndexerSetMethod(index_type);
                MethodInfoEX get_method = target_type.GetIndexerGetMethod(index_type);

                if (set_method != null || get_method != null)
                    return new IndexerInfoEX_MethodPair(set_method, get_method);
            }

            throw new InvalidOperationException("No " + index_type + " indexer exists for the type " + target_type + ".");
        });
        static public IndexerInfoEX GetIndexer(this Type item, Type index_type)
        {
            return GET_INDEXER.Fetch(item, index_type);
        }
    }
}