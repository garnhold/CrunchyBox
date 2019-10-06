using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_IsSetAndGetPublic : Filterer_Simple<PropertyInfo>
    {
        static public readonly Filterer_PropertyInfo_IsSetAndGetPublic INSTANCE = new Filterer_PropertyInfo_IsSetAndGetPublic();

        private Filterer_PropertyInfo_IsSetAndGetPublic()
        {
        }

        public override bool Filter(PropertyInfo item)
        {
            return item.IsSetAndGetPublic();
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> IsSetAndGetPublic()
        {
            return Filterer_PropertyInfo_IsSetAndGetPublic.INSTANCE;
        }
    }
}