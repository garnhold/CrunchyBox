using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public interface ILAddressable
    {
        void RenderIL_LoadAddress(ILCanvas canvas);
    }
}