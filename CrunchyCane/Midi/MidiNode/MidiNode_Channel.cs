using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    using Noodle;
    
    public class MidiNode_Channel : MidiNode
    {
        private int channel_id;

        public MidiNode_Channel(int c, MidiPort p) : base(p)
        {
            SetChannelId(c);
        }

        public MidiNode_Channel(int c) : this(c, null) { }
        public MidiNode_Channel(MidiPort p) : this(0, p) { }
        public MidiNode_Channel() : this(0) { }

        public override void Send(MidiMessage message)
        {
            MidiMessage_ChannelVoice cast;

            if (message.Convert<MidiMessage_ChannelVoice>(out cast))
            {
                cast.SetChannelId(channel_id);
                base.Send(cast);
            }
        }

        public void SetChannelId(int c)
        {
            channel_id = c;
        }

        public int GetChannelId()
        {
            return channel_id;
        }
    }
}