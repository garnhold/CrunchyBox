using System;
using System.IO;

using Avalonia;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAvaloniaEngineInitilizerAttribute : Attribute
    {
    }
}