using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Deconstructable : TyonTypeHandler
    {
        private OperationCache<BasicConversionInvoker, Type> deconstruction_invokers;

        static public readonly TyonTypeHandler_Deconstructable INSTANCE = new TyonTypeHandler_Deconstructable();

        private TyonTypeHandler_Deconstructable()
        {
            deconstruction_invokers = new OperationCache<BasicConversionInvoker, Type>(
                "deconstruction_invokers", 
                t => MarkedMethods<DefinitionDeconstructionAttribute>
                    .GetFilteredMarkedStaticMethods(Filterer_MethodInfo.CanEffectiveParametersHold(t))
                    .GetFirst()
                    .IfNotNull(m => m.GetBasicConversionInvoker())
            );
        }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            value = deconstruction_invokers.Fetch(value.GetType())(value);

            return dehydrater.CreateTyonValue(value.GetTypeEX(), value);
        }

        public override bool IsCompatible(Type type)
        {
            if (deconstruction_invokers.Fetch(type) != null)
                return true;

            return false;
        }
    }
}
