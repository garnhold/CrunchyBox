using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public class MidiNode_Process : MidiNode
    {
        private Process<MidiMessage> process;

        public MidiNode_Process(Process<MidiMessage> pr, MidiPort p) : base(p)
        {
            process = pr;
        }

        public MidiNode_Process(Process<MidiMessage> pr) : this(pr, null) { }

        public override void Send(MidiMessage message)
        {
            process(message);
        }
    }
}