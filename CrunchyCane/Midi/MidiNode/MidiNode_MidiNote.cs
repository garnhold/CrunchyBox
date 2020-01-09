using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public class MidiNode_MidiNote : MidiNode
    {
        private int note_id;
        private float velocity;

        public MidiNode_MidiNote(int n, MidiPort p) : base(p)
        {
            SetNoteId(n);
        }

        public MidiNode_MidiNote(int n) : this(n, null) { }
        public MidiNode_MidiNote(MidiPort p) : this(0, p) { }
        public MidiNode_MidiNote() : this(0) { }

        public void Press(float v)
        {
            if (IsNotPressed())
            {
                velocity = v.BindBetween(0.0f, 1.0f);
                Send(new MidiMessage_ChannelVoice_Note_On(note_id, (int)(velocity * 127.0f)));
            }
        }

        public void Release()
        {
            if (IsPressed())
            {
                velocity = 0.0f;
                Send(new MidiMessage_ChannelVoice_Note_Off(note_id));
            }
        }

        public void SetNoteId(int n)
        {
            note_id = n;
        }

        public int GetNoteId()
        {
            return note_id;
        }

        public float GetVelocity()
        {
            return velocity;
        }

        public bool IsPressed()
        {
            if (velocity > 0.0f)
                return true;

            return false;
        }

        public bool IsNotPressed()
        {
            if (IsPressed() == false)
                return true;

            return false;
        }
    }
}