using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILCanvasLabel_ILGenerator : ILCanvasLabel
    {
        private Label label;
        private ILGenerator generator;

        public ILCanvasLabel_ILGenerator(ILGenerator g, Label l)
        {
            generator = g;
            label = l;
        }

        public override void Emit_Label()
        {
            generator.MarkLabel(label);
        }

        public override void Emit_Br()
        {
            generator.Emit(OpCodes.Br, label);
        }

        public override void Emit_Brtrue()
        {
            generator.Emit(OpCodes.Brtrue, label);
        }

        public override void Emit_Brfalse()
        {
            generator.Emit(OpCodes.Brfalse, label);
        }

        public override void Emit_Leave()
        {
            generator.Emit(OpCodes.Leave, label);
        }
    }
}