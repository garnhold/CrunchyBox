using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract class WinFormsEngine : ApplicationRepresentationEngine<Form, PeriodicProcess_WinForms>
    {
        protected override void AttachLinkSyncroDaemon(Form window, LinkSyncroDaemon daemon)
        {
            window.AttachLinkSyncroDaemon(daemon);
        }

        protected override void StartApplicationInternal(Operation<Form> operation)
        {
            Application.Run(operation());
        }
    }
}