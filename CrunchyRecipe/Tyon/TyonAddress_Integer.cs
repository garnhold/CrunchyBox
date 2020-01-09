
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:41:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonAddress_Integer : TyonAddress
	{
        public TyonAddress_Integer(long n) : this()
        {
            SetInteger(n);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetInteger().ToString());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + GetInteger().GetHashCode();
                hash = hash * 23 + typeof(TyonValue_Integer).GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            TyonAddress_Integer cast;

            if (obj.Convert<TyonAddress_Integer>(out cast))
            {
                if (cast.GetInteger().EqualsEX(GetInteger()))
                    return true;
            }

            return false;
        }
	}
	
}
