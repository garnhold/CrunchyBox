using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	static public partial class CMinor
	{
        static private OperationCache<Operation<object, object>, Type, string, CMinorCompileType> COMPILE_FOR_OBJECT = ReflectionCache.Get().NewOperationCache("COMPILE_FOR_OBJECT", delegate(Type object_type, string code, CMinorCompileType compile_type) {
            return object_type.CreateDynamicMethodDelegateWithForcedParameterTypes<Operation<object, object>>(delegate(ILValue value) {
                CMinorEnvironment environment = new CMinorEnvironment_Object(value);

                switch (compile_type)
                {
                    case CMinorCompileType.Delegate:
                        return CMinorStatement.DOMify(code).Compile(environment);

                    case CMinorCompileType.Lambda:
                        return new ILReturn(CMinorExpression.DOMify(code).CompileAsValue(environment));
                }

                throw new UnaccountedBranchException("compile_type", compile_type);
            }, object_type);
        });
        static public Operation<object, object> CompileForObject(Type object_type, string code, CMinorCompileType compile_type)
        {
            return COMPILE_FOR_OBJECT.Fetch(object_type, code, compile_type);
        }

        static private OperationCache<Operation<object, object, object[]>, Type, string, ContentsEnumerable<KeyValuePair<string, Type>>, CMinorCompileType> COMPILE_FOR_OBJECT_AND_PARAMS = ReflectionCache.Get().NewOperationCache("COMPILE_FOR_OBJECT_AND_PARAMS", delegate(Type object_type, string code, ContentsEnumerable<KeyValuePair<string, Type>> parameters, CMinorCompileType compile_type) {
            ICollection<KeyValuePair<string, Type>> parameters_collection = parameters.PrepareForMultipass();
            IEnumerable<string> parameter_names = parameters_collection.Convert(p => p.Key);
            IEnumerable<Type> parameter_types = parameters_collection.Convert(p => p.Value);

            return object_type.CreateDynamicMethodDelegateWithForcedParameterTypes<Operation<object, object, object[]>>(delegate(ILValue value, ILValue arguments) {
                CMinorEnvironment environment = new CMinorEnvironment_Object_WithParams(
                    value,
                    parameter_names.PairStrict(
                        arguments.GetILExpandedParams(parameter_types)
                    ).ConvertToKeyValuePairs()
                );

                switch(compile_type)
                {
                    case CMinorCompileType.Delegate:
                        return CMinorStatement.DOMify(code).Compile(environment);

                    case CMinorCompileType.Lambda:
                        return new ILReturn(CMinorExpression.DOMify(code).CompileAsValue(environment));
                }

                throw new UnaccountedBranchException("compile_type", compile_type);
            }, object_type, typeof(object[]));
        });
        static public Operation<object, object, object[]> CompileForObjectAndParams(Type object_type, string code, IEnumerable<KeyValuePair<string, Type>> parameters, CMinorCompileType compile_type)
        {
            return COMPILE_FOR_OBJECT_AND_PARAMS.Fetch(object_type, code, new ContentsEnumerable<KeyValuePair<string, Type>>(parameters), compile_type);
        }
	}
}