
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonType_Direct_Templated : TyonType_Direct
	{
        public TyonType_Direct_Templated(Type type) : this()
        {
            SetId(type.GetNamespace().AppendToVisible(".") + type.GetBasicName());
            SetTyonTypes(type.GetGenericArguments().Convert(t => TyonType.CreateTyonType(t)));
        }

        public override Type GetSystemType(TyonHydraterBase hydrater)
        {
            Type[] generic_arguments = GetTyonTypes()
                .Convert(t => t.GetSystemType(hydrater))
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
            ).GetFirst()
            .ChainIfNull(t => hydrater.LogMissingType(GetId()));

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
