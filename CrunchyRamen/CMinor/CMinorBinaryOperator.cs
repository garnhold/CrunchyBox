using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public abstract class CMinorBinaryOperator : CMinorElement
	{
        public abstract BinaryOperatorType GetBinaryOperatorType();
	}
	
}
