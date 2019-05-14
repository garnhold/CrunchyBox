using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_IsPrivateField : Filterer_Simple<FieldInfo>
    {
        static public readonly Filterer_FieldInfo_IsPrivateField INSTANCE = new Filterer_FieldInfo_IsPrivateField();

        private Filterer_FieldInfo_IsPrivateField()
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsPrivateField();
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsPrivateField()
        {
            return Filterer_FieldInfo_IsPrivateField.INSTANCE;
        }
    }
}