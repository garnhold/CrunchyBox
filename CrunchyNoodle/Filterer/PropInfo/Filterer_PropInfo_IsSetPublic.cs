using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_IsSetPublic : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_IsSetPublic INSTANCE = new Filterer_PropInfo_IsSetPublic();

        private Filterer_PropInfo_IsSetPublic()
        {
        }

        public override bool Filter(PropInfoEX item)
        {
            return item.IsSetPublic();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> IsSetPublic()
        {
            return Filterer_PropInfo_IsSetPublic.INSTANCE;
        }
    }
}