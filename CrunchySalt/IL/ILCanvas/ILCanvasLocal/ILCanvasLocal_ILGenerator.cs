using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILCanvasLocal_ILGenerator : ILCanvasLocal
    {
        private LocalBuilder builder;

        public ILCanvasLocal_ILGenerator(LocalBuilder b)
        {
            builder = b;
        }

        public override Type GetLocalType()
        {
            return builder.LocalType;
        }

        public override int GetLocalIndex()
        {
            return builder.LocalIndex;
        }
    }
}