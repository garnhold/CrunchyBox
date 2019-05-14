using System;

using CrunchyDough;

namespace CrunchyCane
{
    public class MidiMessage_ChannelVoice_Note_Pressure : MidiMessage_ChannelVoice_Note
    {
        public MidiMessage_ChannelVoice_Note_Pressure(int n, int v, int c) : base(n, v, c) { }
        public MidiMessage_ChannelVoice_Note_Pressure(int n, int v) : this(n, v, 0) { }
        public MidiMessage_ChannelVoice_Note_Pressure() : this(0, 0) { }

        public override int GetStatusId()
        {
            return 2;
        }
    }
}