
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonType_Templated : TyonType
	{
        public TyonType_Templated(Type type) : this()
        {
            SetId(type.GetBasicName());
            SetTyonTypes(type.GetGenericArguments().Convert(t => TyonType.CreateTyonType(t)));
        }

        public override Type GetSystemType()
        {
            Type generic_type = Types.GetFilteredTypes(
                Filterer_Type.IsBasicNamed(GetId()),
                Filterer_Type.IsGenericClass()
            ).GetFirst();

            return generic_type.MakeGenericType(
                GetTyonTypes().Convert(t => t.GetSystemType()).ToArray()
            );
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetId());
            canvas.AppendToLine("<");
            GetTyonTypes().ProcessWithInterleaving(t => t.Render(canvas), () => canvas.AppendToLine(","));
            canvas.AppendToLine(">");
        }
	}
	
}
