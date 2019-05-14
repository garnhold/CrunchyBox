using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Assembly_DoesReferenceAssembly : Filterer_General<Assembly, IdentifiableAssembly>
    {
        public Filterer_Assembly_DoesReferenceAssembly(Assembly a) : base(a)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.DoesReferenceAssembly(GetId());
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> DoesReferenceAssembly(Assembly assembly)
        {
            return new Filterer_Assembly_DoesReferenceAssembly(assembly);
        }
    }
}