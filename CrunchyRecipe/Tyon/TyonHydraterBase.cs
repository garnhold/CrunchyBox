using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonHydraterBase
	{
        private TyonHydrationMode mode;

        private TyonContext context;

        public TyonHydraterBase(TyonHydrationMode m, TyonContext c)
        {
            mode = m;

            context = c;
        }

        public bool TryGetDesignatedVariable(Type type, string name, out Variable variable)
        {
            return context.GetSettings().TryGetDesignatedVariable(type, name, out variable);
        }

        public void LogMissingType(string id)
        {
            if (mode == TyonHydrationMode.Strict)
                throw new TyonResolutionException("Unable to resolve type " + id);
        }

        public void LogMissingField(Type type, string id)
        {
            if (mode == TyonHydrationMode.Strict)
                throw new TyonResolutionException("Unable to resolve field " + id + " of " + type);
        }

        public TyonContext GetContext()
        {
            return context;
        }
	}
	
}