using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILCanvasLocal_ILTextCanvas : ILCanvasLocal
    {
        private Type local_type;
        private int local_index;

        public ILCanvasLocal_ILTextCanvas(Type t, int i)
        {
            local_type = t;
            local_index = i;
        }

        public override Type GetLocalType()
        {
            return local_type;
        }

        public override int GetLocalIndex()
        {
            return local_index;
        }
    }
}