
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:23 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonType_Normal : TyonType
	{
        public TyonType_Normal(Type type) : this()
        {
            SetId(type.GetBasicName());
        }

        public override Type GetSystemType()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.IsNamed(GetId()),
                Filterer_Type.IsNonGenericClass()
            ).GetFirst();
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetId());
        }
	}
	
}
