using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_DoesNameStartWith : Filterer_General<MethodInfo, IdentifiableString>
    {
        public Filterer_MethodInfo_DoesNameStartWith(string l) : base(l)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.DoesNameStartWith(GetId());
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> DoesNameStartWith(string substring)
        {
            return new Filterer_MethodInfo_DoesNameStartWith(substring);
        }
    }
}