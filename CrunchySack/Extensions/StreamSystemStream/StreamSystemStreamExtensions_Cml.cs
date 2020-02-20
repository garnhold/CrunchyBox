using System;

namespace Crunchy.Sack
{
    using Dough;
    
    static public class StreamSystemStreamExtensions_Cml
    {
        static public AttemptResult AttemptReadCmlEntity(this StreamSystemStream item, out CmlEntity entity, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadCmlEntity(item.GetPath(), out entity, milliseconds);
        }
        static public CmlEntity ReadCmlEntity(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadCmlEntity(item.GetPath(), milliseconds);
        }
    }
}