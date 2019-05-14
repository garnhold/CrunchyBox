using System;
using System.IO;

using System.Windows;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicWPFEngineInitilizerAttribute : Attribute
    {
    }
}