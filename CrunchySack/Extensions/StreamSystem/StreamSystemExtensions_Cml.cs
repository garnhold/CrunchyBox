using System;

namespace Crunchy.Sack
{
    using Dough;
    
    static public class StreamSystemExtensions_Cml
    {
        static public AttemptResult AttemptReadCmlEntity(this StreamSystem item, string path, out CmlEntity entity, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadText<CmlEntity>(path, delegate(string text) {
                return CmlEntity.DOMify(text);
            }, out entity, milliseconds);
        }
        static public CmlEntity ReadCmlEntity(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            CmlEntity output;

            item.AttemptReadCmlEntity(path, out output, milliseconds);
            return output;
        }
    }
}