using System;
using System.Reflection;

namespace Crunchy.Salt
{
    public interface ForeignPropertyInfo
    {
        PropertyInfo GetNativePropertyInfo();
    }
}