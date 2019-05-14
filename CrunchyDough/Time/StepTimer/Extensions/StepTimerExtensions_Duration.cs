using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class StepTimerExtensions_Duration
    {
        static public Duration StepTime(this StepTimer item)
        {
            return Duration.Milliseconds(item.Step());
        }
    }
}