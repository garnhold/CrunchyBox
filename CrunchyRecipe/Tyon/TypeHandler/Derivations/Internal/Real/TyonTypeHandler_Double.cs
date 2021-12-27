using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Double : TyonTypeHandler_ExplicitType<double>
    {
        static public readonly TyonTypeHandler_Double INSTANCE = new TyonTypeHandler_Double();

        private TyonTypeHandler_Double() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Double(value, dehydrater);
        }
    }
}
