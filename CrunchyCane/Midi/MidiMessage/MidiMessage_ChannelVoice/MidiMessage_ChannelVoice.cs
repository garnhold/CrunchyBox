using System;

namespace Crunchy.Cane
{
    using Dough;
    using Noodle;
    
    public abstract class MidiMessage_ChannelVoice : MidiMessage
    {
        private byte channel_id;

        public abstract int GetStatusId();

        public MidiMessage_ChannelVoice(int c)
        {
            SetChannelId(c);
        }

        public MidiMessage_ChannelVoice() : this(0) { }

        public byte CompileStatusByte()
        {
            return (byte)(((IntBits.BIT3 | GetStatusId()) << 4) | GetChannelId());
        }

        public void SetChannelId(int c)
        {
            channel_id = (byte)c.BindBetween(0, 15);
        }

        public int GetChannelId()
        {
            return channel_id;
        }
    }
}