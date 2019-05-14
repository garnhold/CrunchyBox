using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
    public abstract class ILCastInfo
    {
        private Type source_type;
        private Type destination_type;

        public abstract void EmitCast(ILCanvas canvas, ILValue value);

        public ILCastInfo(Type s, Type d)
        {
            source_type = s;
            destination_type = d;
        }

        public virtual void EmitCastAddress(ILCanvas canvas, ILValue value)
        {
            EmitCast(canvas, value);
            canvas.MakeAddressImmediate(GetDestinationType());
        }

        public Type GetSourceType()
        {
            return source_type;
        }

        public Type GetDestinationType()
        {
            return destination_type;
        }
    }
}