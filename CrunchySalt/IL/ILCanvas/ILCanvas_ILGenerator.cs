using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILCanvas_ILGenerator : ILCanvas
    {
        private ILGenerator il_generator;

        protected override ILCanvasLocal CreateLocalInternal(Type type)
        {
            return new ILCanvasLocal_ILGenerator(il_generator.DeclareLocal(type.GetNativeType()));
        }

        public ILCanvas_ILGenerator(MethodBase m, ILGenerator g) : base(m)
        {
            il_generator = g;
        }

        public override ILCanvasLabel CreateLabel()
        {
            return new ILCanvasLabel_ILGenerator(il_generator, il_generator.DefineLabel());
        }

        public override ILCanvasLabel BeginExceptionBlock()
        {
            return new ILCanvasLabel_ILGenerator(il_generator, il_generator.BeginExceptionBlock());
        }

        public override void BeginCatchBlock(Type type)
        {
            il_generator.BeginCatchBlock(type);
        }

        public override void EndExceptionBlock()
        {
            il_generator.EndExceptionBlock();
        }

        public override void Emit_Nop() { il_generator.Emit(OpCodes.Nop); }
        public override void Emit_Throw() { il_generator.Emit(OpCodes.Throw); }
        public override void Emit_Rethrow() { il_generator.Emit(OpCodes.Rethrow); }

        public override void Emit_Dup() { il_generator.Emit(OpCodes.Dup); }
        public override void Emit_Pop() { il_generator.Emit(OpCodes.Pop); }
        public override void Emit_Ret() { il_generator.Emit(OpCodes.Ret); }

        public override void Emit_Ldtoken(Type type) { il_generator.Emit(OpCodes.Ldtoken, type.GetNativeType()); }
        public override void Emit_Ldtoken(FieldInfo field) { il_generator.Emit(OpCodes.Ldtoken, field.GetNativeFieldInfo()); }
        public override void Emit_Ldtoken(MethodInfo method) { il_generator.Emit(OpCodes.Ldtoken, method.GetNativeMethodInfo()); }

        public override void Emit_Castclass(Type type) { il_generator.Emit(OpCodes.Castclass, type.GetNativeType()); }
        public override void Emit_Box(Type type) { il_generator.Emit(OpCodes.Box, type.GetNativeType()); }
        public override void Emit_Unbox_Any(Type type) { il_generator.Emit(OpCodes.Unbox_Any, type.GetNativeType()); }
        public override void Emit_Unbox(Type type) { il_generator.Emit(OpCodes.Unbox, type.GetNativeType()); }
        public override void Emit_Isinst(Type type) { il_generator.Emit(OpCodes.Isinst, type.GetNativeType()); }

        public override void Emit_Newobj(ConstructorInfo constructor) { il_generator.Emit(OpCodes.Newobj, constructor.GetNativeConstructorInfo()); }
        public override void Emit_Newarr(Type type) { il_generator.Emit(OpCodes.Newarr, type.GetNativeType()); }

        public override void Emit_Ldobj(Type type) { il_generator.Emit(OpCodes.Ldobj, type.GetNativeType()); }
        public override void Emit_Stobj(Type type) { il_generator.Emit(OpCodes.Stobj, type.GetNativeType()); }
        public override void Emit_Initobj(Type type) { il_generator.Emit(OpCodes.Initobj, type.GetNativeType()); }

        public override void Emit_Ldftn(MethodInfo method) { il_generator.Emit(OpCodes.Ldftn, method.GetNativeMethodInfo()); }

        public override void Emit_Call(MethodInfo method) { il_generator.Emit(OpCodes.Call, method.GetNativeMethodInfo()); }
        public override void Emit_Call(ConstructorInfo method) { il_generator.Emit(OpCodes.Call, method.GetNativeConstructorInfo()); }
        public override void Emit_Callvirt(MethodInfo method) { il_generator.Emit(OpCodes.Callvirt, method.GetNativeMethodInfo()); }

        public override void Emit_Ldc_I4_M1_Direct() { il_generator.Emit(OpCodes.Ldc_I4_M1); }
        public override void Emit_Ldc_I4_0_Direct() { il_generator.Emit(OpCodes.Ldc_I4_0); }
        public override void Emit_Ldc_I4_1_Direct() { il_generator.Emit(OpCodes.Ldc_I4_1); }
        public override void Emit_Ldc_I4_2_Direct() { il_generator.Emit(OpCodes.Ldc_I4_2); }
        public override void Emit_Ldc_I4_3_Direct() { il_generator.Emit(OpCodes.Ldc_I4_3); }
        public override void Emit_Ldc_I4_4_Direct() { il_generator.Emit(OpCodes.Ldc_I4_4); }
        public override void Emit_Ldc_I4_5_Direct() { il_generator.Emit(OpCodes.Ldc_I4_5); }
        public override void Emit_Ldc_I4_6_Direct() { il_generator.Emit(OpCodes.Ldc_I4_6); }
        public override void Emit_Ldc_I4_7_Direct() { il_generator.Emit(OpCodes.Ldc_I4_7); }
        public override void Emit_Ldc_I4_8_Direct() { il_generator.Emit(OpCodes.Ldc_I4_8); }
        public override void Emit_Ldc_I4_S_Direct(sbyte value) { il_generator.Emit(OpCodes.Ldc_I4_S, value); }
        public override void Emit_Ldc_I4_Direct(int value) { il_generator.Emit(OpCodes.Ldc_I4, value); }

        public override void Emit_Ldc_I8(long value) { il_generator.Emit(OpCodes.Ldc_I8, value); }
        public override void Emit_Ldc_R4(float value) { il_generator.Emit(OpCodes.Ldc_R4, value); }
        public override void Emit_Ldc_R8(double value) { il_generator.Emit(OpCodes.Ldc_R8, value); }

        public override void Emit_Conv_I1() { il_generator.Emit(OpCodes.Conv_I1); }
        public override void Emit_Conv_I2() { il_generator.Emit(OpCodes.Conv_I2); }
        public override void Emit_Conv_I4() { il_generator.Emit(OpCodes.Conv_I4); }
        public override void Emit_Conv_I8() { il_generator.Emit(OpCodes.Conv_I8); }

        public override void Emit_Conv_U1() { il_generator.Emit(OpCodes.Conv_U1); }
        public override void Emit_Conv_U2() { il_generator.Emit(OpCodes.Conv_U2); }
        public override void Emit_Conv_U4() { il_generator.Emit(OpCodes.Conv_U4); }
        public override void Emit_Conv_U8() { il_generator.Emit(OpCodes.Conv_U8); }

        public override void Emit_Conv_R4() { il_generator.Emit(OpCodes.Conv_R4); }
        public override void Emit_Conv_R8() { il_generator.Emit(OpCodes.Conv_R8); }

        public override void Emit_Ldnull() { il_generator.Emit(OpCodes.Ldnull); }
        public override void Emit_Ldstr(string value) { il_generator.Emit(OpCodes.Ldstr, value); }

        public override void Emit_Ldfld(FieldInfo field) { il_generator.Emit(OpCodes.Ldfld, field.GetNativeFieldInfo()); }
        public override void Emit_Ldsfld(FieldInfo field) { il_generator.Emit(OpCodes.Ldsfld, field.GetNativeFieldInfo()); }
        public override void Emit_Ldflda(FieldInfo field) { il_generator.Emit(OpCodes.Ldflda, field.GetNativeFieldInfo()); }
        public override void Emit_Ldsflda(FieldInfo field) { il_generator.Emit(OpCodes.Ldsflda, field.GetNativeFieldInfo()); }

        public override void Emit_Stfld(FieldInfo field) { il_generator.Emit(OpCodes.Stfld, field.GetNativeFieldInfo()); }
        public override void Emit_Stsfld(FieldInfo field) { il_generator.Emit(OpCodes.Stsfld, field.GetNativeFieldInfo()); }

        public override void Emit_Ldarg_0_Direct() { il_generator.Emit(OpCodes.Ldarg_0); }
        public override void Emit_Ldarg_1_Direct() { il_generator.Emit(OpCodes.Ldarg_1); }
        public override void Emit_Ldarg_2_Direct() { il_generator.Emit(OpCodes.Ldarg_2); }
        public override void Emit_Ldarg_3_Direct() { il_generator.Emit(OpCodes.Ldarg_3); }
        public override void Emit_Ldarg_S_Direct(byte index) { il_generator.Emit(OpCodes.Ldarg_S, index); }
        public override void Emit_Ldarg_Direct(ushort index) { il_generator.Emit(OpCodes.Ldarg, index); }

        public override void Emit_Ldarga_S_Direct(byte index) { il_generator.Emit(OpCodes.Ldarga_S, index); }
        public override void Emit_Ldarga_Direct(ushort index) { il_generator.Emit(OpCodes.Ldarga, index); }

        public override void Emit_Starg_S_Direct(byte index) { il_generator.Emit(OpCodes.Starg_S, index); }
        public override void Emit_Starg_Direct(ushort index) { il_generator.Emit(OpCodes.Starg, index); }

        public override void Emit_Ldloc_0_Direct() { il_generator.Emit(OpCodes.Ldloc_0); }
        public override void Emit_Ldloc_1_Direct() { il_generator.Emit(OpCodes.Ldloc_1); }
        public override void Emit_Ldloc_2_Direct() { il_generator.Emit(OpCodes.Ldloc_2); }
        public override void Emit_Ldloc_3_Direct() { il_generator.Emit(OpCodes.Ldloc_3); }
        public override void Emit_Ldloc_S_Direct(byte index) { il_generator.Emit(OpCodes.Ldloc_S, index); }
        public override void Emit_Ldloc_Direct(ushort index) { il_generator.Emit(OpCodes.Ldloc, index); }

        public override void Emit_Ldloca_S_Direct(byte index) { il_generator.Emit(OpCodes.Ldloca_S, index); }
        public override void Emit_Ldloca_Direct(ushort index) { il_generator.Emit(OpCodes.Ldloca, index); }

        public override void Emit_Stloc_0_Direct() { il_generator.Emit(OpCodes.Stloc_0); }
        public override void Emit_Stloc_1_Direct() { il_generator.Emit(OpCodes.Stloc_1); }
        public override void Emit_Stloc_2_Direct() { il_generator.Emit(OpCodes.Stloc_2); }
        public override void Emit_Stloc_3_Direct() { il_generator.Emit(OpCodes.Stloc_3); }
        public override void Emit_Stloc_S_Direct(byte index) { il_generator.Emit(OpCodes.Stloc_S, index); }
        public override void Emit_Stloc_Direct(ushort index) { il_generator.Emit(OpCodes.Stloc, index); }

        public override void Emit_Ldelem_I1() { il_generator.Emit(OpCodes.Ldelem_I1); }
        public override void Emit_Ldelem_I2() { il_generator.Emit(OpCodes.Ldelem_I2); }
        public override void Emit_Ldelem_I4() { il_generator.Emit(OpCodes.Ldelem_I4); }
        public override void Emit_Ldelem_I8() { il_generator.Emit(OpCodes.Ldelem_I8); }

        public override void Emit_Ldelem_U1() { il_generator.Emit(OpCodes.Ldelem_U1); }
        public override void Emit_Ldelem_U2() { il_generator.Emit(OpCodes.Ldelem_U2); }
        public override void Emit_Ldelem_U4() { il_generator.Emit(OpCodes.Ldelem_U4); }
        public override void Emit_Ldelem_U8() { il_generator.Emit(OpCodes.Ldelem_I8); }

        public override void Emit_Ldelem_R4() { il_generator.Emit(OpCodes.Ldelem_R4); }
        public override void Emit_Ldelem_R8() { il_generator.Emit(OpCodes.Ldelem_R8); }

        public override void Emit_Ldelem_Ref() { il_generator.Emit(OpCodes.Ldelem_Ref); }

        public override void Emit_Ldelema(Type type) { il_generator.Emit(OpCodes.Ldelema, type.GetNativeType()); }

        public override void Emit_Stelem_I1() { il_generator.Emit(OpCodes.Stelem_I1); }
        public override void Emit_Stelem_I2() { il_generator.Emit(OpCodes.Stelem_I2); }
        public override void Emit_Stelem_I4() { il_generator.Emit(OpCodes.Stelem_I4); }
        public override void Emit_Stelem_I8() { il_generator.Emit(OpCodes.Stelem_I8); }

        public override void Emit_Stelem_U1() { il_generator.Emit(OpCodes.Stelem_I1); }
        public override void Emit_Stelem_U2() { il_generator.Emit(OpCodes.Stelem_I2); }
        public override void Emit_Stelem_U4() { il_generator.Emit(OpCodes.Stelem_I4); }
        public override void Emit_Stelem_U8() { il_generator.Emit(OpCodes.Stelem_I8); }

        public override void Emit_Stelem_R4() { il_generator.Emit(OpCodes.Stelem_R4); }
        public override void Emit_Stelem_R8() { il_generator.Emit(OpCodes.Stelem_R8); }

        public override void Emit_Stelem_Ref() { il_generator.Emit(OpCodes.Stelem_Ref); }

        public override void Emit_Neg() { il_generator.Emit(OpCodes.Neg); }

        public override void Emit_Mul() { il_generator.Emit(OpCodes.Mul); }
        public override void Emit_Div() { il_generator.Emit(OpCodes.Div); }
        public override void Emit_Rem() { il_generator.Emit(OpCodes.Rem); }
        public override void Emit_Add() { il_generator.Emit(OpCodes.Add); }
        public override void Emit_Sub() { il_generator.Emit(OpCodes.Sub); }

        public override void Emit_And() { il_generator.Emit(OpCodes.And); }
        public override void Emit_Or() { il_generator.Emit(OpCodes.Or); }
        public override void Emit_Not() { il_generator.Emit(OpCodes.Not); }
        public override void Emit_Xor() { il_generator.Emit(OpCodes.Xor); }

        public override void Emit_Ceq() { il_generator.Emit(OpCodes.Ceq); }
        public override void Emit_Clt() { il_generator.Emit(OpCodes.Clt); }
        public override void Emit_Cgt() { il_generator.Emit(OpCodes.Cgt); }
    }
}