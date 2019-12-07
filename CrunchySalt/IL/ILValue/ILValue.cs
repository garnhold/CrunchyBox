using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract partial class ILValue
    {
        public abstract Type GetValueType();
        public abstract bool IsILCostTrivial();

        public virtual bool CanLoad() { return false; }
        public virtual bool CanStore() { return false; }

        public virtual void RenderIL_Load(ILCanvas canvas) { throw new InvalidOperationException(GetType() + " doesn't support loading."); }
        public virtual void RenderIL_Store(ILCanvas canvas, ILValue value) { throw new InvalidOperationException(GetType() + " doesn't support storing."); }

        public abstract void RenderText_Value(ILTextCanvas canvas);

        static public ILValue operator -(ILValue v) { return v.GetILNumericNegated(); }
        static public ILValue operator ~(ILValue v) { return v.GetILOnesComplemented(); }

        static public ILValue operator *(ILValue v1, ILValue v2) { return v1.GetILMultiplied(v2); }
        static public ILValue operator /(ILValue v1, ILValue v2) { return v1.GetILDivided(v2); }
        static public ILValue operator %(ILValue v1, ILValue v2) { return v1.GetILModuloed(v2); }
        
        static public ILValue operator +(ILValue v1, ILValue v2) { return v1.GetILAdded(v2); }
        static public ILValue operator -(ILValue v1, ILValue v2) { return v1.GetILSubtracted(v2); }

        static public ILValue operator &(ILValue v1, ILValue v2) { return v1.GetILANDed(v2); }
        static public ILValue operator |(ILValue v1, ILValue v2) { return v1.GetILORed(v2); }

        public override string ToString()
        {
            ILTextCanvas canvas = new ILTextCanvas(null);

            RenderText_Value(canvas);
            return canvas.ToString();
        }
    }
}