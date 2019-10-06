using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_IsSetPublic : Filterer_Simple<PropertyInfo>
    {
        static public readonly Filterer_PropertyInfo_IsSetPublic INSTANCE = new Filterer_PropertyInfo_IsSetPublic();

        private Filterer_PropertyInfo_IsSetPublic()
        {
        }

        public override bool Filter(PropertyInfo item)
        {
            return item.IsSetPublic();
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> IsSetPublic()
        {
            return Filterer_PropertyInfo_IsSetPublic.INSTANCE;
        }
    }
}