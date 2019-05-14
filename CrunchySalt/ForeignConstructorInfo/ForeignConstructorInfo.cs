using System;
using System.Reflection;

namespace CrunchySalt
{
    public interface ForeignConstructorInfo
    {
        ConstructorInfo GetNativeConstructorInfo();
    }
}