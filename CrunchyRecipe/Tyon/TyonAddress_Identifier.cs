
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:32:29 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonAddress_Identifier : TyonAddress
	{
        public TyonAddress_Identifier(string i) : this()
        {
            SetId(i);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetId());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + GetId().GetHashCode();
                hash = hash * 23 + typeof(TyonAddress_Identifier).GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            TyonAddress_Identifier cast;

            if (obj.Convert<TyonAddress_Identifier>(out cast))
            {
                if (cast.GetId().EqualsEX(GetId()))
                    return true;
            }

            return false;
        }
	}
	
}
