using System;
using System.Reflection;

namespace Crunchy.Salt
{
    public interface ForeignEventInfo
    {
        EventInfo GetNativeEventInfo();
    }
}