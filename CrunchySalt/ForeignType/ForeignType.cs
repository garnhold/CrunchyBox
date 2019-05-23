using System;
using System.Reflection;

namespace CrunchySalt
{
    public interface ForeignType
    {
        Type GetNativeType();
    }
}