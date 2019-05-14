using System;

using CrunchyDough;

namespace CrunchyCane
{
    public class MidiMessage_ChannelVoice_ControlChange : MidiMessage_ChannelVoice
    {
        private byte control_id;
        private byte value;

        public MidiMessage_ChannelVoice_ControlChange(int n, int v, int c) : base(c)
        {
            SetControlId(n);
            SetValue(v);
        }

        public MidiMessage_ChannelVoice_ControlChange(int n, int v) : this(n, v, 0) { }
        public MidiMessage_ChannelVoice_ControlChange() : this(0, 0) { }

        public override int GetStatusId()
        {
            return 3;
        }

        public override byte[] Compile()
        {
            return new byte[] { CompileStatusByte(), CompileFirstDataByte(), CompileSecondDataByte() };
        }

        public byte CompileFirstDataByte()
        {
            return (byte)GetControlId();
        }

        public byte CompileSecondDataByte()
        {
            return (byte)GetValue();
        }

        public void SetControlId(int c)
        {
            control_id = (byte)c.BindBetween(0, 119);
        }

        public void SetValue(int v)
        {
            value = (byte)v.BindBetween(0, 127);
        }

        public int GetControlId()
        {
            return control_id;
        }

        public int GetValue()
        {
            return value;
        }
    }
}