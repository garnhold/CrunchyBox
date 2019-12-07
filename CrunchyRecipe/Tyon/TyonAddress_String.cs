
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
    
    public partial class TyonAddress_String : TyonAddress
	{
        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public TyonAddress_String(string s) : this()
        {
            SetString(s);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetString().StyleAsLiteralString());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + GetString().GetHashCode();
                hash = hash * 23 + typeof(TyonAddress_String).GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            TyonAddress_String cast;

            if (obj.Convert<TyonAddress_String>(out cast))
            {
                if (cast.GetString().EqualsEX(GetString()))
                    return true;
            }

            return false;
        }
	}
	
}
