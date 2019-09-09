using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	static public partial class CMinor_Internal<RETURN_TYPE, OBJECT_TYPE>
	{
        static private OperationCache<Operation<RETURN_TYPE, OBJECT_TYPE>, Type, string> COMPILE_LAMBDA = ReflectionCache.Get().NewOperationCache("COMPILE_LAMBDA", delegate(Type object_type, string code) {
            return CMinorExpression.DOMify(code).CreateObjectLambda<RETURN_TYPE, OBJECT_TYPE>(object_type);
        });
        static public Operation<RETURN_TYPE, OBJECT_TYPE> CompileLambda(Type object_type, string code)
        {
            return COMPILE_LAMBDA.Fetch(object_type, code);
        }

        static private OperationCache<Operation<RETURN_TYPE, OBJECT_TYPE>, Type, string> COMPILE_DELEGATE = ReflectionCache.Get().NewOperationCache("COMPILE_DELEGATE", delegate(Type object_type, string code) {
            return CMinorStatement.DOMify(code).CreateObjectDelegate<RETURN_TYPE, OBJECT_TYPE>(object_type);
        });
        static public Operation<RETURN_TYPE, OBJECT_TYPE> CompileDelegate(Type object_type, string code)
        {
            return COMPILE_DELEGATE.Fetch(object_type, code);
        }
	}
}
