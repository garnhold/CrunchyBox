using System;
using System.Reflection;

namespace Crunchy.Salt
{
    public interface ForeignMethodInfo
    {
        MethodInfo GetNativeMethodInfo();
    }
}