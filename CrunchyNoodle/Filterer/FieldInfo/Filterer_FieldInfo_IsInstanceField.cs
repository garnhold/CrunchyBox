using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_IsInstanceField : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsInstanceField INSTANCE = new Filterer_FieldInfo_IsInstanceField();

        private Filterer_FieldInfo_IsInstanceField()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsInstanceField();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsInstanceField()
        {
            return Filterer_FieldInfo_IsInstanceField.INSTANCE;
        }
    }
}