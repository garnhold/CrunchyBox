using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class StepTimerExtensions_Seconds
    {
        static public float StepSeconds(this StepTimer item)
        {
            return item.StepTime().GetSeconds();
        }
    }
}