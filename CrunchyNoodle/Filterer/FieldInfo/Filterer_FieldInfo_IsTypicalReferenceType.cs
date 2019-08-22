using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_IsTypicalReferenceType : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsTypicalReferenceType INSTANCE = new Filterer_FieldInfo_IsTypicalReferenceType();

        private Filterer_FieldInfo_IsTypicalReferenceType()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsTypicalReferenceType();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsTypicalReferenceType()
        {
            return Filterer_FieldInfo_IsTypicalReferenceType.INSTANCE;
        }
    }
}