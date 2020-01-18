using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicGtkEngineInitilizerAttribute : Attribute
    {
    }
}