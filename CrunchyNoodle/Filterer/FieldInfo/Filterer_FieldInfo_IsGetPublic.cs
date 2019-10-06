using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_IsGetPublic : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsGetPublic INSTANCE = new Filterer_FieldInfo_IsGetPublic();

        private Filterer_FieldInfo_IsGetPublic()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsGetPublic();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsGetPublic()
        {
            return Filterer_FieldInfo_IsGetPublic.INSTANCE;
        }
    }
}