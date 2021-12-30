using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_FieldInfo_IsBackingFieldForPublicSetAndGet : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsBackingFieldForPublicSetAndGet INSTANCE = new Filterer_FieldInfo_IsBackingFieldForPublicSetAndGet();

        private Filterer_FieldInfo_IsBackingFieldForPublicSetAndGet()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsBackingFieldForPublicSetAndGet();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsBackingFieldForPublicSetAndGet()
        {
            return Filterer_FieldInfo_IsBackingFieldForPublicSetAndGet.INSTANCE;
        }
    }
}