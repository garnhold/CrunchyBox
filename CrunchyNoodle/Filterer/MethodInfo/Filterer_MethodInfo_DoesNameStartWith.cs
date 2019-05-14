using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
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