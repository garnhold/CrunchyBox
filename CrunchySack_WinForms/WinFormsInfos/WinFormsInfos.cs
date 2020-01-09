using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    
    public partial class WinFormsInfos : RepresentationInfos
    {
        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : Control
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.Focused == false);
        }
    }
}