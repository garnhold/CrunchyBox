using System;
using System.Runtime.InteropServices;

namespace CrunchyDough
{
    public class Pin
    {
        private GCHandle handle;
        private IntPtr pointer;

        ~Pin()
        {
            UnpinObject();
        }

        public void PinObject(object to_pin)
        {
            UnpinObject();

            handle = GCHandle.Alloc(to_pin, GCHandleType.Pinned);
            pointer = handle.AddrOfPinnedObject();
        }

        public void UnpinObject()
        {
            if (handle.IsAllocated)
                handle.Free();
        }

        public IntPtr GetPointer()
        {
            return pointer;
        }
    }
}