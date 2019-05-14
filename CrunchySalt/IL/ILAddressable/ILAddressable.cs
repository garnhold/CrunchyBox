using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public interface ILAddressable
    {
        void RenderIL_LoadAddress(ILCanvas canvas);
    }
}