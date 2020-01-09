using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class MethodInfoExtensions_Shadow
    {
        static public bool IsMethodEffectiveTypeShadowedBy(this MethodInfo item, Type type)
        {
            return item.GetMethodEffectiveType().IsShadowedBy(type);
        }
        static public bool IsMethodEffectiveTypeNotShadowedBy(this MethodInfo item, Type type)
        {
            if (item.IsMethodEffectiveTypeShadowedBy(type) == false)
                return true;

            return false;
        }
        static public int DetermineEffectiveTypeShadowing(this MethodInfo item, Type type)
        {
            return item.GetMethodEffectiveType().DetermineShadowing(type);
        }

        static public bool IsMethodEffectiveTypeShadowedBy(this MethodInfo item, MethodInfo method_info)
        {
            return item.IsMethodEffectiveTypeShadowedBy(method_info.GetMethodEffectiveType());
        }
        static public bool IsMethodEffectiveTypeNotShadowedBy(this MethodInfo item, MethodInfo method_info)
        {
            if (item.IsMethodEffectiveTypeShadowedBy(method_info) == false)
                return true;

            return false;
        }
        static public int DetermineEffectiveTypeShadowing(this MethodInfo item, MethodInfo method_info)
        {
            return item.GetMethodEffectiveType().DetermineShadowing(method_info.GetMethodEffectiveType());
        }

        static public bool IsMethodEffectiveTypeShadowedByAny(this MethodInfo item, IEnumerable<MethodInfo> method_infos)
        {
            if (method_infos.Has(it => item.IsMethodEffectiveTypeShadowedBy(it)))
                return true;

            return false;
        }
        static public bool IsMethodEffectiveTypeNotShadowedByAny(this MethodInfo item, IEnumerable<MethodInfo> method_infos)
        {
            if (item.IsMethodEffectiveTypeShadowedByAny(method_infos) == false)
                return true;

            return false;
        }

        static public bool IsShadowedBy(this MethodInfo item, MethodInfo method_info)
        {
            if (item.IsNamedTheSame(method_info))
            {
                if (item.IsMethodEffectiveTypeShadowedBy(method_info.GetMethodEffectiveType()))
                    return true;
            }

            return false;
        }
        static public bool IsNotShadowedBy(this MethodInfo item, MethodInfo method_info)
        {
            if (item.IsShadowedBy(method_info) == false)
                return true;

            return false;
        }
        static public int DetermineShadowing(this MethodInfo item, MethodInfo method_info)
        {
            if (item.IsNamedTheSame(method_info))
                return item.DetermineEffectiveTypeShadowing(method_info);

            return 0;
        }

        static public bool IsShadowedByAny(this MethodInfo item, IEnumerable<MethodInfo> method_infos)
        {
            if (method_infos.Has(it => item.IsShadowedBy(it)))
                return true;

            return false;
        }
        static public bool IsNotShadowedByAny(this MethodInfo item, IEnumerable<MethodInfo> method_infos)
        {
            if (item.IsShadowedByAny(method_infos) == false)
                return true;

            return false;
        }
    }
}