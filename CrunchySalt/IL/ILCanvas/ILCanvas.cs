using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class ILCanvas
    {
        private MethodBase method;
        private Pedia<Type, Pit<ILCanvasLocal>> locals;

        public abstract ILCanvasLabel CreateLabel();
        protected abstract ILCanvasLocal CreateLocalInternal(Type type);

        public abstract void Emit_Nop();

        public abstract void Emit_Dup();
        public abstract void Emit_Pop();
        public abstract void Emit_Ret();

        public abstract void Emit_Ldtoken(Type type);
        public abstract void Emit_Ldtoken(FieldInfo field);
        public abstract void Emit_Ldtoken(MethodInfo method);
        
        public abstract void Emit_Castclass(Type type);
        public abstract void Emit_Box(Type type);
        public abstract void Emit_Unbox_Any(Type type);
        public abstract void Emit_Unbox(Type type);
        public abstract void Emit_Isinst(Type type);

        public abstract void Emit_Newobj(ConstructorInfo constructor);
        public abstract void Emit_Newarr(Type type);

        public abstract void Emit_Ldobj(Type type);
        public abstract void Emit_Stobj(Type type);
        public abstract void Emit_Initobj(Type type);

        public abstract void Emit_Call(MethodInfo method);
        public abstract void Emit_Call(ConstructorInfo method);
        public abstract void Emit_Callvirt(MethodInfo method);

        public abstract void Emit_Ldc_I4_M1_Direct();
        public abstract void Emit_Ldc_I4_0_Direct();
        public abstract void Emit_Ldc_I4_1_Direct();
        public abstract void Emit_Ldc_I4_2_Direct();
        public abstract void Emit_Ldc_I4_3_Direct();
        public abstract void Emit_Ldc_I4_4_Direct();
        public abstract void Emit_Ldc_I4_5_Direct();
        public abstract void Emit_Ldc_I4_6_Direct();
        public abstract void Emit_Ldc_I4_7_Direct();
        public abstract void Emit_Ldc_I4_8_Direct();
        public abstract void Emit_Ldc_I4_S_Direct(sbyte value);
        public abstract void Emit_Ldc_I4_Direct(int value);

        public abstract void Emit_Ldc_I8(long value);
        public abstract void Emit_Ldc_R4(float value);
        public abstract void Emit_Ldc_R8(double value);

        public abstract void Emit_Conv_I1();
        public abstract void Emit_Conv_I2();
        public abstract void Emit_Conv_I4();
        public abstract void Emit_Conv_I8();
        public abstract void Emit_Conv_R4();
        public abstract void Emit_Conv_R8();

        public abstract void Emit_Ldnull();
        public abstract void Emit_Ldstr(string value);

        public abstract void Emit_Ldfld(FieldInfo field);
        public abstract void Emit_Ldsfld(FieldInfo field);
        public abstract void Emit_Ldflda(FieldInfo field);
        public abstract void Emit_Ldsflda(FieldInfo field);

        public abstract void Emit_Stfld(FieldInfo field);
        public abstract void Emit_Stsfld(FieldInfo field);

        public abstract void Emit_Ldarg_0_Direct();
        public abstract void Emit_Ldarg_1_Direct();
        public abstract void Emit_Ldarg_2_Direct();
        public abstract void Emit_Ldarg_3_Direct();
        public abstract void Emit_Ldarg_S_Direct(byte index);
        public abstract void Emit_Ldarg_Direct(ushort index);

        public abstract void Emit_Ldarga_S_Direct(byte index);
        public abstract void Emit_Ldarga_Direct(ushort index);

        public abstract void Emit_Starg_S_Direct(byte index);
        public abstract void Emit_Starg_Direct(ushort index);

        public abstract void Emit_Ldloc_0_Direct();
        public abstract void Emit_Ldloc_1_Direct();
        public abstract void Emit_Ldloc_2_Direct();
        public abstract void Emit_Ldloc_3_Direct();
        public abstract void Emit_Ldloc_S_Direct(byte index);
        public abstract void Emit_Ldloc_Direct(ushort index);

        public abstract void Emit_Ldloca_S_Direct(byte index);
        public abstract void Emit_Ldloca_Direct(ushort index);

        public abstract void Emit_Stloc_0_Direct();
        public abstract void Emit_Stloc_1_Direct();
        public abstract void Emit_Stloc_2_Direct();
        public abstract void Emit_Stloc_3_Direct();
        public abstract void Emit_Stloc_S_Direct(byte index);
        public abstract void Emit_Stloc_Direct(ushort index);

        public abstract void Emit_Ldelem_I1();
        public abstract void Emit_Ldelem_I2();
        public abstract void Emit_Ldelem_I4();
        public abstract void Emit_Ldelem_I8();
        public abstract void Emit_Ldelem_R4();
        public abstract void Emit_Ldelem_R8();
        public abstract void Emit_Ldelem_Ref();

        public abstract void Emit_Ldelema(Type type);

        public abstract void Emit_Stelem_I1();
        public abstract void Emit_Stelem_I2();
        public abstract void Emit_Stelem_I4();
        public abstract void Emit_Stelem_I8();
        public abstract void Emit_Stelem_R4();
        public abstract void Emit_Stelem_R8();
        public abstract void Emit_Stelem_Ref();

        public abstract void Emit_Neg();

        public abstract void Emit_Mul();
        public abstract void Emit_Div();
        public abstract void Emit_Rem();
        public abstract void Emit_Add();
        public abstract void Emit_Sub();

        public abstract void Emit_And();
        public abstract void Emit_Or();
        public abstract void Emit_Not();

        public abstract void Emit_Ceq();
        public abstract void Emit_Clt();
        public abstract void Emit_Cgt();

        public ILCanvas(MethodBase m)
        {
            method = m;

            locals = new Pedia<Type, Pit<ILCanvasLocal>>(
                t => new Pit<ILCanvasLocal>(() => CreateLocalInternal(t))
            );
        }

        public void Emit_Ldc_I4(int value)
        {
            switch (value)
            {
                case -1: Emit_Ldc_I4_M1_Direct(); return;
                case 0: Emit_Ldc_I4_0_Direct(); return;
                case 1: Emit_Ldc_I4_1_Direct(); return;
                case 2: Emit_Ldc_I4_2_Direct(); return;
                case 3: Emit_Ldc_I4_3_Direct(); return;
                case 4: Emit_Ldc_I4_4_Direct(); return;
                case 5: Emit_Ldc_I4_5_Direct(); return;
                case 6: Emit_Ldc_I4_6_Direct(); return;
                case 7: Emit_Ldc_I4_7_Direct(); return;
                case 8: Emit_Ldc_I4_8_Direct(); return;
            }

            if (value.CanFitInSignedByte())
                Emit_Ldc_I4_S_Direct((sbyte)value);
            else
                Emit_Ldc_I4_Direct(value);
        }

        public void Emit_Ldarg(int index)
        {
            switch (index)
            {
                case 0: Emit_Ldarg_0_Direct(); return;
                case 1: Emit_Ldarg_1_Direct(); return;
                case 2: Emit_Ldarg_2_Direct(); return;
                case 3: Emit_Ldarg_3_Direct(); return;
            }

            if (index.CanFitInByte())
                Emit_Ldarg_S_Direct((byte)index);
            else
                Emit_Ldarg_Direct((ushort)index);
        }
        public void Emit_Ldarga(int index)
        {
            if (index.CanFitInByte())
                Emit_Ldarga_S_Direct((byte)index);
            else
                Emit_Ldarga_Direct((ushort)index);
        }

        public void Emit_Starg(int index)
        {
            if (index.CanFitInByte())
                Emit_Starg_S_Direct((byte)index);
            else
                Emit_Starg_Direct((ushort)index);
        }

        public void Emit_Ldloc(int index)
        {
            switch (index)
            {
                case 0: Emit_Ldloc_0_Direct(); return;
                case 1: Emit_Ldloc_1_Direct(); return;
                case 2: Emit_Ldloc_2_Direct(); return;
                case 3: Emit_Ldloc_3_Direct(); return;
            }

            if (index.CanFitInByte())
                Emit_Ldloc_S_Direct((byte)index);
            else
                Emit_Ldloc_Direct((ushort)index);
        }

        public void Emit_Ldloca(int index)
        {
            if (index.CanFitInByte())
                Emit_Ldloca_S_Direct((byte)index);
            else
                Emit_Ldloca_Direct((ushort)index);
        }

        public void Emit_Stloc(int index)
        {
            switch (index)
            {
                case 0: Emit_Stloc_0_Direct(); return;
                case 1: Emit_Stloc_1_Direct(); return;
                case 2: Emit_Stloc_2_Direct(); return;
                case 3: Emit_Stloc_3_Direct(); return;
            }

            if (index.CanFitInByte())
                Emit_Stloc_S_Direct((byte)index);
            else
                Emit_Stloc_Direct((ushort)index);
        }

        public void Finish()
        {
            if (method.HasNoReturn())
                Emit_Ret();
        }

        public ILCanvasLocal CreateLocal(Type type)
        {
            return locals.GetValue(type).Pop();
        }
        public void ReleaseLocal(ILCanvasLocal local)
        {
            locals.GetValue(local.GetLocalType()).Push(local);
        }

        public MethodBase GetMethod()
        {
            return method;
        }
    }
}