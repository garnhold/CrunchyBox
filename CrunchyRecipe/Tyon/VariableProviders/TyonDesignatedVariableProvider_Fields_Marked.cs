using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonDesignatedVariableProvider_Fields_Marked<ATTRIBUTE_TYPE> : TyonDesignatedVariableProvider_Fields where ATTRIBUTE_TYPE : Attribute
    {
        static public readonly TyonDesignatedVariableProvider_Fields_Marked<ATTRIBUTE_TYPE> INSTANCE = new TyonDesignatedVariableProvider_Fields_Marked<ATTRIBUTE_TYPE>();

        private TyonDesignatedVariableProvider_Fields_Marked() { }

        protected override Filterer<FieldInfo> GetFieldInfoFilterer(Type type)
        {
            return Filterer_FieldInfo.HasCustomAttributeOfType<ATTRIBUTE_TYPE>();
        }
    }
}
