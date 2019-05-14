using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_DoesNameContain : Filterer_General<FieldInfo, IdentifiableString>
    {
        public Filterer_FieldInfo_DoesNameContain(string l) : base(l)
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.DoesNameContain(GetId());
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> DoesNameContain(string substring)
        {
            return new Filterer_FieldInfo_DoesNameContain(substring);
        }
    }
}