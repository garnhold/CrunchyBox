using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_IsDeclaredWithin : Filterer_General<FieldInfo, IdentifiableType>
    {
        public Filterer_FieldInfo_IsDeclaredWithin(Type l) : base(l)
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.IsDeclaredWithin(GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeDeclaredWithin(GetId())
            );
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> IsDeclaredWithin(Type type)
        {
            return new Filterer_FieldInfo_IsDeclaredWithin(type);
        }
    }
}