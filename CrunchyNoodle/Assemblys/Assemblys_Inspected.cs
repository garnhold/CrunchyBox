using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public partial class Assemblys
    {
        static private void AbsorbInspectedAssemblys(Assembly target, HashSet<Assembly> absorbed, HashSet<Assembly> visited)
        {
            if (visited.Add(target))
            {
                if (target.HasCustomAttributeOfType<InspectedAssemblyAttribute>(false))
                    absorbed.Add(target);

                target.GetAllCustomAttributesOfType<InspectAssemblysAttribute>(false)
                    .Convert(a => a.GetAssemblys())
                    .Flatten()
                    .Process(delegate(Assembly sub_target) {
                        absorbed.Add(sub_target);
                        AbsorbInspectedAssemblys(sub_target, absorbed, visited);
                    });
            }
        }

        static private OperationCache<HashSet<Assembly>> GET_ALL_INSPECTED_ASSEMBLYS = ReflectionCache.Get().NewOperationCache("GET_ALL_INSPECTED_ASSEMBLYS", delegate() {
            HashSet<Assembly> absorbed = new HashSet<Assembly>();
            HashSet<Assembly> visited = new HashSet<Assembly>();

            AppDomain.CurrentDomain.GetAssemblies().ProcessCopy(a => AbsorbInspectedAssemblys(a, absorbed, visited));
            return absorbed;
        });
        static public IEnumerable<Assembly> GetAllInspectedAssemblys()
        {
            return GET_ALL_INSPECTED_ASSEMBLYS.Fetch();
        }
    }
}