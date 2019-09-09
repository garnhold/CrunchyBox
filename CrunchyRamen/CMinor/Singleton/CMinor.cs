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
        static public Operation<RETURN_TYPE, OBJECT_TYPE> CompileLambda<RETURN_TYPE, OBJECT_TYPE>(Type object_type, string code)
        {
            return CMinor_Internal<RETURN_TYPE, OBJECT_TYPE>.CompileLambda(object_type, code);
        }
        static public Operation<object, object> CompileLambda(Type object_type, string code)
        {
            return CompileLambda<object, object>(object_type, code);
        }

        static public Operation<RETURN_TYPE, OBJECT_TYPE> CompileDelegate<RETURN_TYPE, OBJECT_TYPE>(Type object_type, string code)
        {
            return CMinor_Internal<RETURN_TYPE, OBJECT_TYPE>.CompileDelegate(object_type, code);
        }
        static public Operation<object, object> CompileDelegate(Type object_type, string code)
        {
            return CompileDelegate<object, object>(object_type, code);
        }
	}
}
