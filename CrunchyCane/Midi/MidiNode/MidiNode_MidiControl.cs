using System;

namespace Crunchy.Cane
{
    using Dough;
    
    public class MidiNode_MidiControl : MidiNode
    {
        private int control_id;

        private float value;
        private int quantized_value;

        private void SetQuantizedValue(int q)
        {
            if (quantized_value != q)
            {
                quantized_value = q;
                Send(new MidiMessage_ChannelVoice_ControlChange(control_id, quantized_value));
            }
        }

        private void PushValue()
        {
            SetQuantizedValue((int)(value * 127.0f));
        }

        public MidiNode_MidiControl(int c, MidiPort p) : base(p)
        {
            SetControlId(c);
        }

        public MidiNode_MidiControl(int c) : this(c, null) { }
        public MidiNode_MidiControl(MidiPort p) : this(0, p) { }
        public MidiNode_MidiControl() : this(0) { }

        public void SetControlId(int c)
        {
            control_id = c;

            PushValue();
        }

        public void SetValue(float v)
        {
            value = v.BindBetween(0.0f, 1.0f);

            PushValue();
        }

        public int GetControlId()
        {
            return control_id;
        }

        public float GetValue()
        {
            return value;
        }
    }
}