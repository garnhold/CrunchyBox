using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_IsBackingField : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsBackingField INSTANCE = new Filterer_FieldInfo_IsBackingField();

        private Filterer_FieldInfo_IsBackingField()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsBackingField();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsBackingField()
        {
            return Filterer_FieldInfo_IsBackingField.INSTANCE;
        }
    }
}