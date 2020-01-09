using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_PropInfo_CanBeTreatedAs<T> : Filterer_PropInfo_CanBeTreatedAs
    {
        static public readonly Filterer_PropInfo_CanBeTreatedAs<T> INSTANCE = new Filterer_PropInfo_CanBeTreatedAs<T>();

        private Filterer_PropInfo_CanBeTreatedAs() : base(typeof(T)) { }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> CanBeTreatedAs<T>()
        {
            return Filterer_PropInfo_CanBeTreatedAs<T>.INSTANCE;
        }
    }

    public class Filterer_PropInfo_CanBeTreatedAs : Filterer_General<PropInfoEX, IdentifiableType>
    {
        public Filterer_PropInfo_CanBeTreatedAs(Type t) : base(t) { }

        public override bool Filter(PropInfoEX item)
        {
            if (item.GetPropType().CanBeTreatedAs(GetId()))
                return true;

            return false;
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> CanBeTreatedAs(Type type)
        {
            return new Filterer_PropInfo_CanBeTreatedAs(type);
        }
    }
}