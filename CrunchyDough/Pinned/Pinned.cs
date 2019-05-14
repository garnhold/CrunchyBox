using System;
using System.Runtime.InteropServices;

namespace CrunchyDough
{
    public class Pinned<T>
    {
        private Pin pin;
        private T pinned;

        static public implicit operator T(Pinned<T> pinned)
        {
            return pinned.GetPinned();
        }

        static public implicit operator IntPtr(Pinned<T> pinned)
        {
            return pinned.GetPointer();
        }

        public Pinned()
        {
            pin = new Pin();
        }

        ~Pinned()
        {
            Clear();
        }

        public void Set(T to_pin)
        {
            pin.PinObject(to_pin);
            pinned = to_pin;
        }

        public void Clear()
        {
            pin.UnpinObject();
            pinned = default(T);
        }

        public T GetPinned()
        {
            return pinned;
        }

        public IntPtr GetPointer()
        {
            return pin.GetPointer();
        }
    }
}