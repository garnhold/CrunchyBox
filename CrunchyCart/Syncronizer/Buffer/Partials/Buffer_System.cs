using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        public partial class Buffer
        {
            public System ReadSystemReference()
            {
                return syncronizer.system_manager.ReadSystemReference(this);
            }
            public System WriteSystemReference(System system)
            {
                syncronizer.system_manager.WriteSystemReference(this, system);

                return system;
            }

            public SystemMethod ReadSystemMethod()
            {
                return syncronizer.constant_manager.GetSystemMethodSubManager().ReadConstantReference(this);
            }
            public void WriteSystemMethod(SystemMethod method)
            {
                syncronizer.constant_manager.GetSystemMethodSubManager().WriteConstantReference(method, this);
            }
        }
    }
}