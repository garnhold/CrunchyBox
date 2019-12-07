using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    using Noodle;
    
    public abstract class MidiNode : MidiPort
    {
        private MidiPort port;

        public MidiNode(MidiPort p)
        {
            SetPort(p);
        }

        public MidiNode() : this(null) { }

        public virtual void Send(MidiMessage message)
        {
            if (port != null)
                port.Send(message);
        }

        public void SetPort(MidiPort p)
        {
            port = p;
        }

        public MidiPort GetPort()
        {
            return port;
        }
    }
}