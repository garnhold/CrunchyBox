using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class UnitDefinition_ThatIsNThis : UnitDefinition_ThisIsNThat
    {
        public UnitDefinition_ThatIsNThis(string sn, string pn, UnitDefinition u, double n, IEnumerable<string> a) : base(sn, pn, 1.0 / n, u, a) { }
        public UnitDefinition_ThatIsNThis(string sn, string pn, UnitDefinition u, double n, params string[] a) : this(sn, pn, u, n, (IEnumerable<string>)a) { }
    }
}