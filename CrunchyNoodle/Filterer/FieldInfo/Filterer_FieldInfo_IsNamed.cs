using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_IsNamed : Filterer_General<FieldInfo, IdentifiableString>
    {
        public Filterer_FieldInfo_IsNamed(string l) : base(l)
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsNamed(GetId());
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsNamed(string name)
        {
            return new Filterer_FieldInfo_IsNamed(name);
        }
    }
}