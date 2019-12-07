using System;
using System.Reflection;

namespace Crunchy.Salt
{
    public interface ForeignConstructorInfo
    {
        ConstructorInfo GetNativeConstructorInfo();
    }
}