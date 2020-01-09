using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class UnexpectedSignatureException : Exception
    {
        public UnexpectedSignatureException(IEnumerable<Type> types)
            : base("Encountered an unexpected signature: " + types.ToString(", "))
        {
        }

        public UnexpectedSignatureException(params Type[] types) : this((IEnumerable<Type>)types) { }
    }
}