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
    public class ILIndexed : ILValue, ILAddressable
    {
        private IndexerInfoEX indexer_info;

        private ILValue target;
        private ILValue index;

        public ILIndexed(IndexerInfoEX ii, ILValue t, ILValue i)
        {
            indexer_info = ii;

            target = t;
            index = i;
        }

        public ILIndexed(ILValue t, ILValue i) : this(t.GetValueType().GetIndexer(i.GetValueType()) , t, i) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            indexer_info.RenderIL_Load(canvas, target, index);
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            indexer_info.RenderIL_LoadAddress(canvas, target, index);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            indexer_info.RenderIL_Store(canvas, target, index, value);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            target.RenderText_Value(canvas);

            canvas.AppendToLine("[");
                index.RenderText_Value(canvas);
            canvas.AppendToLine("]");
        }

        public override Type GetValueType()
        {
            return indexer_info.GetElementType();
        }

        public override bool IsILCostTrivial()
        {
            return false;
        }

        public override bool CanLoad()
        {
            if (indexer_info.CanLoad())
                return true;

            return false;
        }

        public override bool CanStore()
        {
            if (indexer_info.CanStore())
                return true;

            return false;
        }
    }
}