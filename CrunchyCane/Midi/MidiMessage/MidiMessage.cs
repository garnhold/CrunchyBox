using System;

using CrunchyDough;

namespace CrunchyCane
{
    public abstract class MidiMessage
    {
        public abstract byte[] Compile();
    }
}