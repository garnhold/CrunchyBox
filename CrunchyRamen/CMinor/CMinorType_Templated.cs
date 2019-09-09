
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:15:13 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public partial class CMinorType_Templated : CMinorType
	{
        public override Type GetSystemType()
        {
            Type[] arguments = GetCMinorTypeList().GetSystemTypes().ToArray();

            return Types.GetFilteredTypes(
                Filterer_Type.IsBasicNamed(GetId()),
                Filterer_Type.IsGenericClass(),
                Filterer_Type.CanGenericParametersHold(arguments)
            ).GetFirst()
            .IfNotNull(t => t.MakeGenericType(arguments));
        }
	}
	
}
