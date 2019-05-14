using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class IndexerInfoEX
    {
        private Type declaring_type;

        private Type index_type;
        private Type element_type;

        public abstract bool CanLoad();
        public abstract bool CanStore();

        public abstract void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index);
        public abstract void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value);

        public virtual void RenderIL_LoadAddress(ILCanvas canvas, ILValue target, ILValue index)
        {
            RenderIL_Load(canvas, target, index);
            canvas.MakeAddressImmediate(element_type);
        }

        public IndexerInfoEX(Type d, Type i, Type e)
        {
            declaring_type = d;

            index_type = i;
            element_type = e;
        }

        public Type GetDeclaringType()
        {
            return declaring_type;
        }

        public Type GetIndexType()
        {
            return index_type;
        }

        public Type GetElementType()
        {
            return element_type;
        }
    }
}