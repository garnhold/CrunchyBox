using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public delegate object Invoker(object target, object[] arguments);

        public delegate object[] ArgumentReader(Buffer buffer);
        public delegate void ArgumentWriter(object[] arguments, Buffer buffer);

        public abstract class EntityInvokable
        {
            private MethodInfo method;

            private Invoker invoker;

            private ArgumentReader argument_reader;
            private ArgumentWriter argument_writer;

            private T CreateDelegate<T>(Delegate operation)
            {
                return method.DeclaringType.CreateDynamicMethodDelegate<T>(typeof(T).Name + "<" + method.Name + ">", operation);
            }

            protected object Invoke(object target, object[] arguments)
            {
                if (invoker == null)
                {
                    invoker = CreateDelegate<Invoker>((Operation<ILStatement, ILValue, ILValue>)delegate(ILValue il_target, ILValue il_arguments) {
                        return il_target.GetILMethodInvokation(method, il_arguments.GetILExpandedParams());
                    });
                }

                return invoker(target, arguments);
            }

            protected object[] ReadArguments(Buffer buffer)
            {
                if (argument_reader == null)
                {
                    argument_reader = CreateDelegate<ArgumentReader>((Operation<ILStatement, ILValue>)delegate(ILValue il_buffer) {
                        return new ILReturn(
                            new ILNewPopulatedArray(
                                typeof(object),
                                method.GetEffectiveParameterTypes().Convert(t => ILSerialize.GenerateObjectRead(t, il_buffer))
                            )
                        );
                    });
                }

                return argument_reader(buffer);
            }

            protected void WriteArguments(object[] arguments, Buffer buffer)
            {
                if (argument_writer == null)
                {
                    argument_writer = CreateDelegate<ArgumentWriter>((Operation<ILStatement, ILValue, ILValue>)delegate(ILValue il_arguments, ILValue il_buffer) {
                        return il_arguments.GetILExpandedParams()
                            .Convert(v => ILSerialize.GenerateObjectWrite(v, il_buffer))
                            .ToBlock();
                    });
                }

                argument_writer(arguments, buffer);
            }

            public EntityInvokable(MethodInfo m)
            {
                method = m;
            }

            public MethodInfo GetMethod()
            {
                return method;
            }

            public string GetName()
            {
                return method.Name;
            }

            public Type GetDeclaringType()
            {
                return method.DeclaringType;
            }
        }
    }
}