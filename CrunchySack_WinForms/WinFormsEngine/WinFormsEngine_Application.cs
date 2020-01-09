using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class WinFormsEngine : RepresentationEngine
    {
        public void StartApplication(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            Application.Run(CreateWindowRepresentation(target, layout));
        }

        public void StartApplication(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            Application.Run(CreateWindowRepresentation(target, milliseconds, process, layout));
        }
    }
}