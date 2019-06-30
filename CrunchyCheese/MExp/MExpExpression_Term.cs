
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 15:40:47 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCheese
{
	public partial class MExpExpression_Term : MExpExpression
	{
        public override ILValue GetILValue()
        {
            return new ILVirtualParameter(
                typeof(float),
                this.GetParent<MExpEntry>().GetTermIndex(GetId())
            );
        }
	}
	
}
