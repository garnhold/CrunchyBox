using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        public partial class Buffer
        {
            public Type ReadType()
            {
                return syncronizer.constant_manager.GetTypeSubManager().ReadConstantReference(this);
            }
            public void WriteType(Type type)
            {
                syncronizer.constant_manager.GetTypeSubManager().WriteConstantReference(type, this);
            }
        }
    }
}