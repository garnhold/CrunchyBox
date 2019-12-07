using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public abstract class MidiMessage
    {
        public abstract byte[] Compile();
    }
}