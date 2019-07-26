
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
	public partial class TyonType_Direct_Normal : TyonType_Direct
	{
        public TyonType_Direct_Normal(Type type) : this()
        {
            SetId(type.GetNamespace().AppendToVisible(".") + type.GetBasicName());
        }

        public override Type GetSystemType()
        {
            IEnumerable<Filterer<Type>> filters = new Filterer<Type>[] {
                Filterer_Type.IsNamed(GetName()),
                Filterer_Type.IsNonNestedClass(),
                Filterer_Type.IsNonGenericClass()
            };
            
            return Types.GetFilteredTypes(
                filters.AppendIf(
                    HasNamespace(),
                    Filterer_Type.IsNamespace(GetNamespace())
                )
            ).GetFirst();
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetId());
        }
	}
	
}