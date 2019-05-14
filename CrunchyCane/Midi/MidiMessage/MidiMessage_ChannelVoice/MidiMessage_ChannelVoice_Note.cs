using System;

using CrunchyDough;

namespace CrunchyCane
{
    public abstract class MidiMessage_ChannelVoice_Note : MidiMessage_ChannelVoice
    {
        private byte note_id;
        private byte velocity;

        public MidiMessage_ChannelVoice_Note(int n, int v, int c) : base(c)
        {
            SetNoteId(n);
            SetVelocity(v);
        }

        public MidiMessage_ChannelVoice_Note(int n, int v) : this(n, v, 0) { }
        public MidiMessage_ChannelVoice_Note() : this(0, 0) { }

        public override byte[] Compile()
        {
            return new byte[] { CompileStatusByte(), CompileFirstDataByte(), CompileSecondDataByte() };
        }

        public byte CompileFirstDataByte()
        {
            return (byte)GetNoteId();
        }

        public byte CompileSecondDataByte()
        {
            return (byte)GetVelocity();
        }

        public void SetNoteId(int n)
        {
            note_id = (byte)n.BindBetween(0, 127);
        }

        public void SetVelocity(int v)
        {
            velocity = (byte)v.BindBetween(0, 127);
        }

        public int GetNoteId()
        {
            return note_id;
        }

        public int GetVelocity()
        {
            return velocity;
        }
    }
}