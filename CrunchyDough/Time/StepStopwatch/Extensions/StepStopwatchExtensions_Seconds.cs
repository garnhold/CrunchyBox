using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class StepStopwatchExtensions_Seconds
    {
        static public float StepSeconds(this StepStopwatch item)
        {
            return item.StepTime().GetSeconds();
        }
    }
}