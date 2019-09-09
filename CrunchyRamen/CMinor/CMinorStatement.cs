
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 08 2019 13:32:01 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public abstract partial class CMinorStatement : CMinorElement
	{
        public abstract ILStatement Compile(CMinorEnvironment environment);

        public Operation<RETURN_TYPE, OBJECT_TYPE> CreateObjectDelegate<RETURN_TYPE, OBJECT_TYPE>(Type object_type)
        {
            return object_type.CreateDynamicMethodDelegateWithForcedParameterTypes<Operation<RETURN_TYPE, OBJECT_TYPE>>(delegate(ILValue value) {
                return Compile(
                    new CMinorEnvironment_Object(value)
                );
            }, object_type);
        }
        public Operation<object, object> CreateObjectDelegate(Type object_type)
        {
            return CreateObjectDelegate<object, object>(object_type);
        }
	}
	
}
