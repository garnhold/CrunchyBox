using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public class MidiMessage_ChannelVoice_ChannelPressure : MidiMessage_ChannelVoice
    {
        private byte pressure;

        public MidiMessage_ChannelVoice_ChannelPressure(int v, int c) : base(c)
        {
            SetPressure(v);
        }

        public MidiMessage_ChannelVoice_ChannelPressure(int v) : this(v, 0) { }
        public MidiMessage_ChannelVoice_ChannelPressure() : this(0) { }

        public override int GetStatusId()
        {
            return 4;
        }

        public override byte[] Compile()
        {
            return new byte[] { CompileStatusByte(), CompileFirstDataByte() };
        }

        public byte CompileFirstDataByte()
        {
            return (byte)GetPressure();
        }

        public void SetPressure(int p)
        {
            pressure = (byte)p.BindBetween(0, 127);
        }

        public int GetPressure()
        {
            return pressure;
        }
    }
}