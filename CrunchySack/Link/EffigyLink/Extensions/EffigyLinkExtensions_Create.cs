using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class EffigyLinkExtensions_Create
    {
        static public void CreateRepresentationInto(this EffigyLink item, object value, Process<object> process)
        {
            item.CreateRepresentationInto(value, new CmlContainer_EndPoint_SystemValueProcess(process));
        }

        static public object CreateAndGetRepresentationInto(this EffigyLink item, object value, CmlContainer container)
        {
            item.CreateRepresentationInto(value, container);

            return container.ForceContainedSystemValue();
        }
        static public object CreateAndGetRepresentationInto(this EffigyLink item, object value, Process<object> process)
        {
            return item.CreateAndGetRepresentationInto(value, new CmlContainer_EndPoint_SystemValueProcess(process));
        }
    }
}