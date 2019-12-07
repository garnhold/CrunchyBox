using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public class MidiMessage_ChannelVoice_Note_On : MidiMessage_ChannelVoice_Note
    {
        public MidiMessage_ChannelVoice_Note_On(int n, int v, int c) : base(n, v, c) { }
        public MidiMessage_ChannelVoice_Note_On(int n, int v) : this(n, v, 0) { }
        public MidiMessage_ChannelVoice_Note_On() : this(0, 0) { }

        public override int GetStatusId()
        {
            return 1;
        }
    }
}