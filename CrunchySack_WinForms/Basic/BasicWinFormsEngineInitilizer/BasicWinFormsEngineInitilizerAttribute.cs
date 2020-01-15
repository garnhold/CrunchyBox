using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicWinFormsEngineInitilizerAttribute : Attribute
    {
    }
}