
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
    public abstract class TyonType_Direct : TyonType
	{
        public abstract string GetId();

        public override object InstanceSystemType()
        {
            return GetSystemType().CreateForcedInstance();
        }

        public string GetName()
        {
            return GetId().Offset(GetId().FindLastIndexOf(".") + 1);
        }

        public string GetNamespace()
        {
            return GetId().Truncate(GetId().FindLastIndexOf("."));
        }

        public bool HasNamespace()
        {
            if (GetId().Contains("."))
                return true;

            return false;
        }
	}
	
}
