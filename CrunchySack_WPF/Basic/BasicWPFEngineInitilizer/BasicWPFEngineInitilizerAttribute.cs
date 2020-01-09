using System;
using System.IO;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicWPFEngineInitilizerAttribute : Attribute
    {
    }
}