
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: December 27 2021 1:49:43 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

namespace Crunchy.Recipe
{
	public partial class TyonAddress_Int : TyonAddress
	{
        public TyonAddress_Int(int n) : this()
        {
            SetInt(n);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetInt().StyleAsLiteral());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + GetInt().GetHashCode();
                hash = hash * 23 + typeof(int).GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            TyonAddress_Int cast;

            if (obj.Convert<TyonAddress_Int>(out cast))
            {
                if (cast.GetInt().EqualsEX(GetInt()))
                    return true;
            }

            return false;
        }
    }
	
}
