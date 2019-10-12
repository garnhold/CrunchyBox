using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableExtensions_Override
    {
        static public Variable GetOverridenTypeVariable(this Variable item, Type type)
        {
            return new Variable_OverrideType(type, item);
        }

        static public Variable GetOverridenTypeAndNameVariable(this Variable item, Type type, string name)
        {
            return new Variable_OverrideTypeAndName(type, name, item);
        }
    }
}