using System;
using System.Reflection;

namespace Crunchy.Salt
{
    public interface ForeignFieldInfo
    {
        FieldInfo GetNativeFieldInfo();
    }
}