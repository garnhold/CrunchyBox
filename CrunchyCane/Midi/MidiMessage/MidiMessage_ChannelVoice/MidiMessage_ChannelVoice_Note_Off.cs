using System;

using CrunchyDough;

namespace CrunchyCane
{
    public class MidiMessage_ChannelVoice_Note_Off : MidiMessage_ChannelVoice_Note
    {
        public MidiMessage_ChannelVoice_Note_Off(int n, int v, int c) : base(n, v, c) { }
        public MidiMessage_ChannelVoice_Note_Off(int n, int v) : this(n, v, 0) { }
        public MidiMessage_ChannelVoice_Note_Off(int n) : this(n, 0) { }
        public MidiMessage_ChannelVoice_Note_Off() : this(0, 0) { }

        public override int GetStatusId()
        {
            return 0;
        }
    }
}