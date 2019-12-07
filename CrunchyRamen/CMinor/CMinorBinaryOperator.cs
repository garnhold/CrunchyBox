using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CMinorBinaryOperator : CMinorElement
	{
        public abstract BinaryOperatorType GetBinaryOperatorType();
	}
	
}
