using System;

namespace Crunchy.Dough
{    
    public class RandFloatSource_IntSource : RandFloatSource
    {
        private RandIntSource int_source;

        public RandFloatSource_IntSource(RandIntSource i)
        {
            int_source = i;
        }

        public override float Get()
        {
            return (float)int_source.Get() / (float)int.MaxValue;
        }
    }
}