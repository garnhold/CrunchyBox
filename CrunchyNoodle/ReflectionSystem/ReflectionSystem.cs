using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class ReflectionSystem
    {
        static public void Prerun()
        {
            Assemblys.GetAllInspectedAssemblys();

            Types.GetFilteredTypes();
            typeof(object).GetAllInstanceMethods();
        }
    }
}