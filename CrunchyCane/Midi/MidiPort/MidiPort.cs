using System;

namespace CrunchyCane
{
    public interface MidiPort
    {
        void Send(MidiMessage message);
    }
}