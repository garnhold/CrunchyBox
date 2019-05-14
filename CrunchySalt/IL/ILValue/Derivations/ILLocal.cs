using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILLocal : ILValue, ILAddressable
    {
        private Type local_type;
        private string local_name;

        private ILValue initial_value;

        private bool is_cemented;
        private bool is_initialized;

        private ILCanvasLocal canvas_local;

        private void RenderIL_StoreImmediateInternal(ILCanvas canvas)
        {
            canvas.Emit_Stloc(canvas_local.GetLocalIndex());

            is_initialized = true;
        }

        public ILLocal(Type t, string n, ILValue iv, bool ic)
        {
            local_type = t;
            local_name = n.StyleAsEntity();

            initial_value = iv;
            is_cemented = ic;
            is_initialized = false;
        }

        public void Allocate(ILCanvas canvas)
        {
            canvas_local = canvas.CreateLocal(local_type);

            is_initialized = false;
        }

        public void Release(ILCanvas canvas)
        {
            canvas.ReleaseLocal(canvas_local);
            canvas_local = null;
        }

        public void RenderIL_Initialize(ILCanvas canvas)
        {
            if (is_initialized)
                throw new InvalidOperationException("Locals should only be initialized once.");

            if (initial_value != null)
            {
                initial_value.RenderIL_Load(canvas);
                RenderIL_StoreImmediateInternal(canvas);
            }

            is_initialized = true;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldloc(canvas_local.GetLocalIndex());
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            canvas.Emit_Ldloca(canvas_local.GetLocalIndex());
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            RenderIL_StoreImmediate(canvas);
        }

        public void RenderIL_StoreImmediate(ILCanvas canvas)
        {
            if (is_cemented)
                throw new InvalidOperationException("Cannot store to cemented locals.");

            RenderIL_StoreImmediateInternal(canvas);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine(local_name);
        }

        public void RenderText_Declaration(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine(local_type.Name);
            canvas.AppendToLine(" ");
            canvas.AppendToLine(local_name);

            if (initial_value != null)
            {
                canvas.AppendToLine(" = ");
                initial_value.RenderText_Value(canvas);
            }

            canvas.AppendToLine(";");
        }

        public bool IsCemented()
        {
            return is_cemented;
        }

        public override Type GetValueType()
        {
            return local_type;
        }

        public override bool IsILCostTrivial()
        {
            return true;
        }

        public override bool CanLoad()
        {
            return true;
        }

        public override bool CanStore()
        {
            if (is_cemented)
                return false;

            return true;
        }
    }
}