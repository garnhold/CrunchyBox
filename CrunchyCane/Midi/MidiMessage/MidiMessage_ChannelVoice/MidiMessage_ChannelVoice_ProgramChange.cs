using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public class MidiMessage_ChannelVoice_ProgramChange : MidiMessage_ChannelVoice
    {
        private byte program_id;

        public MidiMessage_ChannelVoice_ProgramChange(int p, int c) : base(c)
        {
            SetProgramId(p);
        }

        public MidiMessage_ChannelVoice_ProgramChange(int p) : this(p, 0) { }
        public MidiMessage_ChannelVoice_ProgramChange() : this(0) { }

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
            return (byte)GetProgramId();
        }

        public void SetProgramId(int p)
        {
            program_id = (byte)p.BindBetween(0, 127);
        }

        public int GetProgramId()
        {
            return program_id;
        }
    }
}