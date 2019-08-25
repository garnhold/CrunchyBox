
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: July 18 2019 22:37:32 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonType_Array : TyonType
	{
        public TyonType_Array(Type type) : this()
        {
            SetTyonType(TyonType.CreateTyonType(type.GetElementType()));
        }

        public override Type GetSystemType(TyonHydrater hydrater)
        {
            return GetTyonType().GetSystemType(hydrater).MakeArrayType();
        }

        public override object InstanceSystemType(TyonHydrater hydrater)
        {
            return null;
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonType().Render(canvas);
            canvas.AppendToLine("[]");
        }
	}
	
}
