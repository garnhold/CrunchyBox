using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class StepStopwatchExtensions_Duration
    {
        static public Duration StepTime(this StepStopwatch item)
        {
            return Duration.Milliseconds(item.Step());
        }
    }
}