
using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    
    public class IndexerInfoEX_Array_SByte : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_SByte INSTANCE = new IndexerInfoEX_Array_SByte();

        private IndexerInfoEX_Array_SByte() : base(typeof(sbyte)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_I1();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_I1();
        }
    }

    public class IndexerInfoEX_Array_Short : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_Short INSTANCE = new IndexerInfoEX_Array_Short();

        private IndexerInfoEX_Array_Short() : base(typeof(short)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_I2();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_I2();
        }
    }

    public class IndexerInfoEX_Array_Int : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_Int INSTANCE = new IndexerInfoEX_Array_Int();

        private IndexerInfoEX_Array_Int() : base(typeof(int)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_I4();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_I4();
        }
    }

    public class IndexerInfoEX_Array_Long : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_Long INSTANCE = new IndexerInfoEX_Array_Long();

        private IndexerInfoEX_Array_Long() : base(typeof(long)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_I8();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_I8();
        }
    }

    public class IndexerInfoEX_Array_Byte : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_Byte INSTANCE = new IndexerInfoEX_Array_Byte();

        private IndexerInfoEX_Array_Byte() : base(typeof(byte)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_U1();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_U1();
        }
    }

    public class IndexerInfoEX_Array_UShort : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_UShort INSTANCE = new IndexerInfoEX_Array_UShort();

        private IndexerInfoEX_Array_UShort() : base(typeof(ushort)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_U2();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_U2();
        }
    }

    public class IndexerInfoEX_Array_UInt : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_UInt INSTANCE = new IndexerInfoEX_Array_UInt();

        private IndexerInfoEX_Array_UInt() : base(typeof(uint)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_U4();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_U4();
        }
    }

    public class IndexerInfoEX_Array_ULong : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_ULong INSTANCE = new IndexerInfoEX_Array_ULong();

        private IndexerInfoEX_Array_ULong() : base(typeof(ulong)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_U8();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_U8();
        }
    }

    public class IndexerInfoEX_Array_Float : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_Float INSTANCE = new IndexerInfoEX_Array_Float();

        private IndexerInfoEX_Array_Float() : base(typeof(float)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_R4();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_R4();
        }
    }

    public class IndexerInfoEX_Array_Double : IndexerInfoEX_Array
    {
		static public readonly IndexerInfoEX_Array_Double INSTANCE = new IndexerInfoEX_Array_Double();

        private IndexerInfoEX_Array_Double() : base(typeof(double)) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_R8();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);
            
            value.GetILImplicitCast(GetElementType())
                .RenderIL_Load(canvas);

            canvas.Emit_Stelem_R8();
        }
    }
}

