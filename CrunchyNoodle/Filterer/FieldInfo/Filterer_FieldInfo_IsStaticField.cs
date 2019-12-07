using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_IsStaticField : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsStaticField INSTANCE = new Filterer_FieldInfo_IsStaticField();

        private Filterer_FieldInfo_IsStaticField()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsStaticField();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsStaticField()
        {
            return Filterer_FieldInfo_IsStaticField.INSTANCE;
        }
    }
}