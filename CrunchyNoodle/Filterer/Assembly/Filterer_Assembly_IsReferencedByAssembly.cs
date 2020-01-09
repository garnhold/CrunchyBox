using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Assembly_IsReferencedByAssembly : Filterer_General<Assembly, IdentifiableAssembly>
    {
        public Filterer_Assembly_IsReferencedByAssembly(Assembly a) : base(a)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.IsReferencedByAssembly(GetId());
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> IsReferencedByAssembly(Assembly assembly)
        {
            return new Filterer_Assembly_IsReferencedByAssembly(assembly);
        }
    }
}