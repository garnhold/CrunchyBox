using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class DistributedInitilizationInstance<INSTANCE_TYPE, ATTRIBUTE_TYPE> where ATTRIBUTE_TYPE : Attribute
    {
        private INSTANCE_TYPE instance;

        public void Clear()
        {
            instance = default(INSTANCE_TYPE);
        }

        public INSTANCE_TYPE Get()
        {
            if (instance == null)
            {
                instance = typeof(INSTANCE_TYPE).CreateInstance<INSTANCE_TYPE>();

                MarkedMethods<ATTRIBUTE_TYPE>.InvokeFilteredMarkedStaticMethods<INSTANCE_TYPE>(instance);
            }

            return instance;
        }
    }
}