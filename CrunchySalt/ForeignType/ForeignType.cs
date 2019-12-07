using System;
using System.Reflection;

namespace Crunchy.Salt
{
    public interface ForeignType
    {
        Type GetNativeType();
    }
}