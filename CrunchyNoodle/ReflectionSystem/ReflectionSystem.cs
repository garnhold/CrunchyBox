using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
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