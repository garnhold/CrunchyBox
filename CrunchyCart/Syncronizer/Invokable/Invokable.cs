using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        public delegate object Invoker(object target, object[] arguments);

        public delegate object[] ArgumentReader(Buffer buffer);
        public delegate void ArgumentWriter(object[] arguments, Buffer buffer);

        public abstract class Invokable
        {
            private MethodInfo method;

            private Invoker invoker;

            private ArgumentReader argument_reader;
            private ArgumentWriter argument_writer;

            protected object Invoke(object target, object[] arguments)
            {
                if (invoker == null)
                {
                    invoker = method.DeclaringType.CreateDynamicMethodDelegate<Invoker>(delegate(ILValue il_target, ILValue il_arguments) {
                        return new ILReturn(
                            il_target.GetILMethodInvokation(method, il_arguments.GetILExpandedParams(method))
                        );
                    });
                }

                return invoker(target, arguments);
            }

            protected object[] ReadArguments(Buffer buffer)
            {
                if (argument_reader == null)
                {
                    argument_reader = method.DeclaringType.CreateDynamicMethodDelegate<ArgumentReader>(delegate(ILValue il_buffer) {
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
                    argument_writer = method.DeclaringType.CreateDynamicMethodDelegate<ArgumentWriter>(delegate(ILValue il_arguments, ILValue il_buffer) {
                        return il_arguments.GetILExpandedParams(method)
                            .Convert(v => ILSerialize.GenerateObjectWrite(v, il_buffer))
                            .ToBlock();
                    });
                }

                argument_writer(arguments, buffer);
            }

            public Invokable(MethodInfo m)
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