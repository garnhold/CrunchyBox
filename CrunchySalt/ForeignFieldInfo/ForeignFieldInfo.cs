using System;
using System.Reflection;

namespace CrunchySalt
{
    public interface ForeignFieldInfo
    {
        FieldInfo GetNativeFieldInfo();
    }
}