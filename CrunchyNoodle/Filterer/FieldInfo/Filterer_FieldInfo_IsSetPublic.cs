using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_IsSetPublic : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsSetPublic INSTANCE = new Filterer_FieldInfo_IsSetPublic();

        private Filterer_FieldInfo_IsSetPublic()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsSetPublic();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsSetPublic()
        {
            return Filterer_FieldInfo_IsSetPublic.INSTANCE;
        }
    }
}