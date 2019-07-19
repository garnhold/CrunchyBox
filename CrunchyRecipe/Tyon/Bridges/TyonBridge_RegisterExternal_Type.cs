using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonBridge_RegisterExternal_Type<T> : TyonBridge_RegisterExternal_Type
    {
        static public readonly TyonBridge_RegisterExternal_Type<T> INSTANCE = new TyonBridge_RegisterExternal_Type<T>();

        private TyonBridge_RegisterExternal_Type() : base(typeof(T)) { }
    }

    public class TyonBridge_RegisterExternal_Type : TyonBridge_RegisterExternal
    {
        private Type type;

        public TyonBridge_RegisterExternal_Type(Type t)
        {
            type = t;
        }

        public override bool IsCompatible(Variable variable)
        {
            if (variable.GetVariableType().CanBeTreatedAs(type))
                return true;

            return false;
        }
    }
}
