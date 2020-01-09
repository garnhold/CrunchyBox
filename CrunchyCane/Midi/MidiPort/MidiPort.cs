using System;

namespace Crunchy.Cane
{
    public interface MidiPort
    {
        void Send(MidiMessage message);
    }
}