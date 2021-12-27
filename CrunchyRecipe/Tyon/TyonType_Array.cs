
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: July 18 2019 22:37:32 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonType_Array : TyonType
	{
        public TyonType_Array(Type type) : this()
        {
            SetTyonType(TyonType.CreateTyonType(type.GetElementType()));
        }

        public override object InstanceSystemObject(TyonHydrater hydrater, object[] arguments)
        {
            return null;
        }

        public override Type GetSystemType(TyonHydrater hydrater)
        {
            return GetTyonType().GetSystemType(hydrater).IfNotNull(t => t.MakeArrayType());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonType().Render(canvas);
            canvas.AppendToLine("[]");
        }
	}
	
}
