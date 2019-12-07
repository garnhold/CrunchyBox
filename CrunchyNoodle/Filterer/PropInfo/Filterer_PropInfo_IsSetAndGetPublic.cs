using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_PropInfo_IsSetAndGetPublic : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_IsSetAndGetPublic INSTANCE = new Filterer_PropInfo_IsSetAndGetPublic();

        private Filterer_PropInfo_IsSetAndGetPublic()
        {
        }

        public override bool Filter(PropInfoEX item)
        {
            return item.IsSetAndGetPublic();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> IsSetAndGetPublic()
        {
            return Filterer_PropInfo_IsSetAndGetPublic.INSTANCE;
        }
    }
}