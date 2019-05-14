
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class CmlScriptValue_Argument_Single_Operation<T> : CmlScriptValue_Argument_Single
    {
        private Operation<T> operation;

        public CmlScriptValue_Argument_Single_Operation(Operation<T> o)
        {
            operation = o;
        }

        public override object GetArgument()
        {
            return operation();
        }

        public override Type GetValueType()
        {
            return typeof(T);
        }
    }

}
