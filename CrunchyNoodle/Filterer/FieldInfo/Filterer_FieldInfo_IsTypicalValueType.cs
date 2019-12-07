using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_IsTypicalValueType : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsTypicalValueType INSTANCE = new Filterer_FieldInfo_IsTypicalValueType();

        private Filterer_FieldInfo_IsTypicalValueType()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsTypicalValueType();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsTypicalValueType()
        {
            return Filterer_FieldInfo_IsTypicalValueType.INSTANCE;
        }
    }
}