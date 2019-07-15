using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILCanvas_ILTextCanvas : ILCanvas
    {
        private ILTextCanvas canvas;
        private int next_local_id = 0;

        protected override ILCanvasLocal CreateLocalInternal(Type type)
        {
            return new ILCanvasLocal_ILTextCanvas(type, next_local_id++);
        }

        public ILCanvas_ILTextCanvas(MethodBase m, ILTextCanvas c) : base(m)
        {
            canvas = c;
        }

        public override ILCanvasLabel CreateLabel()
        {
            return new ILCanvasLabel_ILTextCanvas(canvas);
        }

        public override ILCanvasLabel BeginExceptionBlock()
        {
            canvas.AppendToNewline("BeginExceptionBlock");

            return CreateLabel();
        }

        public override void BeginCatchBlock(Type type)
        {
            canvas.AppendToNewline("BeginCatchBlock(" + type + ")");
        }

        public override void EndExceptionBlock()
        {
            canvas.AppendToNewline("EndExceptionBlock");
        }
        
        public override void Emit_Nop() { canvas.AppendInstruction("Nop"); }
        public override void Emit_Throw() { canvas.AppendToNewline("Throw"); }
        public override void Emit_Rethrow() { canvas.AppendToNewline("Rethrow"); }

        public override void Emit_Dup() { canvas.AppendInstruction("Dup"); }
        public override void Emit_Pop() { canvas.AppendInstruction("Pop"); }
        public override void Emit_Ret() { canvas.AppendInstruction("Ret"); }

        public override void Emit_Ldtoken(Type type) { canvas.AppendInstruction("Ldtoken", type.Name); }
        public override void Emit_Ldtoken(FieldInfo field) { canvas.AppendInstruction("Ldtoken", field.Name); }
        public override void Emit_Ldtoken(MethodInfo method) { canvas.AppendInstruction("Ldtoken", method.Name); }

        public override void Emit_Castclass(Type type) { canvas.AppendInstruction("Castclass", type.Name); }
        public override void Emit_Box(Type type) { canvas.AppendInstruction("Box", type.Name); }
        public override void Emit_Unbox_Any(Type type) { canvas.AppendInstruction("Unbox_Any", type.Name); }
        public override void Emit_Unbox(Type type) { canvas.AppendInstruction("Unbox", type.Name); }
        public override void Emit_Isinst(Type type) { canvas.AppendInstruction("Isinst", type.Name); }

        public override void Emit_Newobj(ConstructorInfo constructor) { canvas.AppendInstruction("Newobj", constructor.ToString()); }
        public override void Emit_Newarr(Type type) { canvas.AppendInstruction("Newarr", type.Name); }

        public override void Emit_Ldobj(Type type) { canvas.AppendInstruction("Ldobj", type.Name); }
        public override void Emit_Stobj(Type type) { canvas.AppendInstruction("Stobj", type.Name); }
        public override void Emit_Initobj(Type type) { canvas.AppendInstruction("Initobj", type.Name); }

        public override void Emit_Call(MethodInfo method) { canvas.AppendInstruction("Call", method.ToString()); }
        public override void Emit_Call(ConstructorInfo method) { canvas.AppendInstruction("Call", method.ToString()); }
        public override void Emit_Callvirt(MethodInfo method) { canvas.AppendInstruction("Callvirt", method.ToString()); }

        public override void Emit_Ldc_I4_M1_Direct() { canvas.AppendInstruction("Ldc.I4.M1"); }
        public override void Emit_Ldc_I4_0_Direct() { canvas.AppendInstruction("Ldc.I4.0"); }
        public override void Emit_Ldc_I4_1_Direct() { canvas.AppendInstruction("Ldc.I4.1"); }
        public override void Emit_Ldc_I4_2_Direct() { canvas.AppendInstruction("Ldc.I4.2"); }
        public override void Emit_Ldc_I4_3_Direct() { canvas.AppendInstruction("Ldc.I4.3"); }
        public override void Emit_Ldc_I4_4_Direct() { canvas.AppendInstruction("Ldc.I4.4"); }
        public override void Emit_Ldc_I4_5_Direct() { canvas.AppendInstruction("Ldc.I4.5"); }
        public override void Emit_Ldc_I4_6_Direct() { canvas.AppendInstruction("Ldc.I4.6"); }
        public override void Emit_Ldc_I4_7_Direct() { canvas.AppendInstruction("Ldc.I4.7"); }
        public override void Emit_Ldc_I4_8_Direct() { canvas.AppendInstruction("Ldc.I4.8"); }
        public override void Emit_Ldc_I4_S_Direct(sbyte value) { canvas.AppendInstruction("Ldc.I4.S", value.ToString()); }
        public override void Emit_Ldc_I4_Direct(int value) { canvas.AppendInstruction("Ldc.I4", value.ToString()); }

        public override void Emit_Ldc_I8(long value) { canvas.AppendInstruction("Ldc.I8", value.ToString()); }
        public override void Emit_Ldc_R4(float value) { canvas.AppendInstruction("Ldc.R4", value.ToString()); }
        public override void Emit_Ldc_R8(double value) { canvas.AppendInstruction("Ldc.R8", value.ToString()); }

        public override void Emit_Conv_I1() { canvas.AppendInstruction("Conv.I1"); }
        public override void Emit_Conv_I2() { canvas.AppendInstruction("Conv.I2"); }
        public override void Emit_Conv_I4() { canvas.AppendInstruction("Conv.I4"); }
        public override void Emit_Conv_I8() { canvas.AppendInstruction("Conv.I8"); }
        public override void Emit_Conv_R4() { canvas.AppendInstruction("Conv.R4"); }
        public override void Emit_Conv_R8() { canvas.AppendInstruction("Conv.R8"); }

        public override void Emit_Ldnull() { canvas.AppendInstruction("Ldnull"); }
        public override void Emit_Ldstr(string value) { canvas.AppendInstruction("Ldstr", value.StyleAsLiteralString()); }

        public override void Emit_Ldfld(FieldInfo field) { canvas.AppendInstruction("Ldfld", field.ToString()); }
        public override void Emit_Ldsfld(FieldInfo field) { canvas.AppendInstruction("Ldsfld", field.ToString()); }

        public override void Emit_Ldflda(FieldInfo field) { canvas.AppendInstruction("Ldflda", field.ToString()); }
        public override void Emit_Ldsflda(FieldInfo field) { canvas.AppendInstruction("Ldsflda", field.ToString()); }

        public override void Emit_Stfld(FieldInfo field) { canvas.AppendInstruction("Stfld", field.ToString()); }
        public override void Emit_Stsfld(FieldInfo field) { canvas.AppendInstruction("Stsfld", field.ToString()); }

        public override void Emit_Ldarg_0_Direct() { canvas.AppendInstruction("Ldarg.0"); }
        public override void Emit_Ldarg_1_Direct() { canvas.AppendInstruction("Ldarg.1"); }
        public override void Emit_Ldarg_2_Direct() { canvas.AppendInstruction("Ldarg.2"); }
        public override void Emit_Ldarg_3_Direct() { canvas.AppendInstruction("Ldarg.3"); }
        public override void Emit_Ldarg_S_Direct(byte index) { canvas.AppendInstruction("Ldarg.S", index.ToString()); }
        public override void Emit_Ldarg_Direct(ushort index) { canvas.AppendInstruction("Ldarg", index.ToString()); }

        public override void Emit_Ldarga_S_Direct(byte index) { canvas.AppendInstruction("Ldarga.S", index.ToString()); }
        public override void Emit_Ldarga_Direct(ushort index) { canvas.AppendInstruction("Ldarga", index.ToString()); }

        public override void Emit_Starg_S_Direct(byte index) { canvas.AppendInstruction("Starg.S", index.ToString()); }
        public override void Emit_Starg_Direct(ushort index) { canvas.AppendInstruction("Starg", index.ToString()); }

        public override void Emit_Ldloc_0_Direct() { canvas.AppendInstruction("Ldloc.0"); }
        public override void Emit_Ldloc_1_Direct() { canvas.AppendInstruction("Ldloc.1"); }
        public override void Emit_Ldloc_2_Direct() { canvas.AppendInstruction("Ldloc.2"); }
        public override void Emit_Ldloc_3_Direct() { canvas.AppendInstruction("Ldloc.3"); }
        public override void Emit_Ldloc_S_Direct(byte index) { canvas.AppendInstruction("Ldloc.S", index.ToString()); }
        public override void Emit_Ldloc_Direct(ushort index) { canvas.AppendInstruction("Ldloc", index.ToString()); }

        public override void Emit_Ldloca_S_Direct(byte index) { canvas.AppendInstruction("Ldloca.S", index.ToString()); }
        public override void Emit_Ldloca_Direct(ushort index) { canvas.AppendInstruction("Ldloca", index.ToString()); }

        public override void Emit_Stloc_0_Direct() { canvas.AppendInstruction("Stloc.0"); }
        public override void Emit_Stloc_1_Direct() { canvas.AppendInstruction("Stloc.1"); }
        public override void Emit_Stloc_2_Direct() { canvas.AppendInstruction("Stloc.2"); }
        public override void Emit_Stloc_3_Direct() { canvas.AppendInstruction("Stloc.3"); }
        public override void Emit_Stloc_S_Direct(byte index) { canvas.AppendInstruction("Stloc.S", index.ToString()); }
        public override void Emit_Stloc_Direct(ushort index) { canvas.AppendInstruction("Stloc", index.ToString()); }

        public override void Emit_Ldelem_I1() { canvas.AppendInstruction("Ldelem.I1"); }
        public override void Emit_Ldelem_I2() { canvas.AppendInstruction("Ldelem.I2"); }
        public override void Emit_Ldelem_I4() { canvas.AppendInstruction("Ldelem.I4"); }
        public override void Emit_Ldelem_I8() { canvas.AppendInstruction("Ldelem.I8"); }
        public override void Emit_Ldelem_R4() { canvas.AppendInstruction("Ldelem.R4"); }
        public override void Emit_Ldelem_R8() { canvas.AppendInstruction("Ldelem.R8"); }
        public override void Emit_Ldelem_Ref() { canvas.AppendInstruction("Ldelem.Ref"); }

        public override void Emit_Ldelema(Type type) { canvas.AppendInstruction("Ldelema", type.Name); }

        public override void Emit_Stelem_I1() { canvas.AppendInstruction("Stelem.I1"); }
        public override void Emit_Stelem_I2() { canvas.AppendInstruction("Stelem.I2"); }
        public override void Emit_Stelem_I4() { canvas.AppendInstruction("Stelem.I4"); }
        public override void Emit_Stelem_I8() { canvas.AppendInstruction("Stelem.I8"); }
        public override void Emit_Stelem_R4() { canvas.AppendInstruction("Stelem.R4"); }
        public override void Emit_Stelem_R8() { canvas.AppendInstruction("Stelem.R8"); }
        public override void Emit_Stelem_Ref() { canvas.AppendInstruction("Stelem.Ref"); }

        public override void Emit_Neg() { canvas.AppendInstruction("Neg"); }

        public override void Emit_Mul() { canvas.AppendInstruction("Mul"); }
        public override void Emit_Div() { canvas.AppendInstruction("Div"); }
        public override void Emit_Rem() { canvas.AppendInstruction("Rem"); }
        public override void Emit_Add() { canvas.AppendInstruction("Add"); }
        public override void Emit_Sub() { canvas.AppendInstruction("Sub"); }

        public override void Emit_And() { canvas.AppendInstruction("And"); }
        public override void Emit_Or() { canvas.AppendInstruction("Or"); }
        public override void Emit_Not() { canvas.AppendInstruction("Not"); }
        public override void Emit_Xor() { canvas.AppendInstruction("Xor"); }

        public override void Emit_Ceq() { canvas.AppendInstruction("Ceq"); }
        public override void Emit_Clt() { canvas.AppendInstruction("Clt"); }
        public override void Emit_Cgt() { canvas.AppendInstruction("Cgt"); }
    }
}