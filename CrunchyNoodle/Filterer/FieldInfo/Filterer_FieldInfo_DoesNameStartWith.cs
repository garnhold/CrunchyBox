using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_DoesNameStartWith : Filterer_General<FieldInfo, IdentifiableString>
    {
        public Filterer_FieldInfo_DoesNameStartWith(string l) : base(l)
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.DoesNameStartWith(GetId());
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> DoesNameStartWith(string substring)
        {
            return new Filterer_FieldInfo_DoesNameStartWith(substring);
        }
    }
}