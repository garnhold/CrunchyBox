using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_IsGetPublic : Filterer_Simple<PropertyInfo>
    {
        static public readonly Filterer_PropertyInfo_IsGetPublic INSTANCE = new Filterer_PropertyInfo_IsGetPublic();

        private Filterer_PropertyInfo_IsGetPublic()
        {
        }

        public override bool Filter(PropertyInfo item)
        {
            return item.IsGetPublic();
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> IsGetPublic()
        {
            return Filterer_PropertyInfo_IsGetPublic.INSTANCE;
        }
    }
}