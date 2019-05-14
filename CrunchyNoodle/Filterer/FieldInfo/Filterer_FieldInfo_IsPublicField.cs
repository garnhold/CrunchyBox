using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_IsPublicField : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsPublicField INSTANCE = new Filterer_FieldInfo_IsPublicField();

        private Filterer_FieldInfo_IsPublicField()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsPublicField();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsPublicField()
        {
            return Filterer_FieldInfo_IsPublicField.INSTANCE;
        }
    }
}