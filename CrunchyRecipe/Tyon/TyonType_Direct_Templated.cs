
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
	public partial class TyonType_Direct_Templated : TyonType_Direct
	{
        public TyonType_Direct_Templated(Type type) : this()
        {
            SetId(type.GetNamespace().AppendToVisible(".") + type.GetBasicName());
            SetTyonTypes(type.GetGenericArguments().Convert(t => TyonType.CreateTyonType(t)));
        }

        public override Type GetSystemType()
        {
            Type[] generic_arguments = GetTyonTypes()
                .Convert(t => t.GetSystemType())
                .ToArray();

            IEnumerable<Filterer<Type>> filters = new Filterer<Type>[] {
                    Filterer_Type.IsBasicNamed(GetName()),
                    Filterer_Type.IsGenericClass(),
                    Filterer_Type.IsNonNestedClass(), 
                    Filterer_Type.CanGenericParametersHold(generic_arguments)
            };

            Type generic_type = Types.GetFilteredTypes(
                filters.AppendIf(
                    HasNamespace(),
                    Filterer_Type.IsNamespace(GetNamespace())
                )
            ).GetFirst();

            return generic_type.MakeGenericType(generic_arguments);
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
