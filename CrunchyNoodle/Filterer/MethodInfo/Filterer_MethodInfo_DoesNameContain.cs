using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_DoesNameContain : Filterer_General<MethodInfo, IdentifiableString>
    {
        public Filterer_MethodInfo_DoesNameContain(string l) : base(l)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.DoesNameContain(GetId());
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> DoesNameContain(string substring)
        {
            return new Filterer_MethodInfo_DoesNameContain(substring);
        }
    }
}