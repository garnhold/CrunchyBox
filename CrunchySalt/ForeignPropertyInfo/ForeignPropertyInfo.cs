using System;
using System.Reflection;

namespace CrunchySalt
{
    public interface ForeignPropertyInfo
    {
        PropertyInfo GetNativePropertyInfo();
    }
}