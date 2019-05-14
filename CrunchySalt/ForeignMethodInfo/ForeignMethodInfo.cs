using System;
using System.Reflection;

namespace CrunchySalt
{
    public interface ForeignMethodInfo
    {
        MethodInfo GetNativeMethodInfo();
    }
}