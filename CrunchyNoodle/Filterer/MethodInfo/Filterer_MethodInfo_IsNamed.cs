using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsNamed : Filterer_General<MethodInfo, IdentifiableString>
    {
        public Filterer_MethodInfo_IsNamed(string l) : base(l)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsNamed(GetId());
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsNamed(string name)
        {
            return new Filterer_MethodInfo_IsNamed(name);
        }
    }
}