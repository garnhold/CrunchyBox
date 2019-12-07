using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Integer : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Integer INSTANCE = new TyonTypeHandler_Integer();

        private TyonTypeHandler_Integer() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Integer(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsInteger())
                return true;

            return false;
        }
    }
}
