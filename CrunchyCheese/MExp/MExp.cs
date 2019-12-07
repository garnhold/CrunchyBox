
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 15:40:47 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cheese
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class MExp
    {
        static private OperationCache<Operation<float, float>, string, string> CREATE_OPERATION1 = ReflectionCache.Get().NewOperationCache("CREATE_OPERATION1", delegate(string text, string term) {
            return MExpEntry.Compile<Operation<float, float>>(text, term);
        });
        static public Operation<float, float> GetOperation(string text, string term)
        {
            return CREATE_OPERATION1.Fetch(text, term);
        }
    }
	
}
