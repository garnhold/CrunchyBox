using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    static public class FunctionSyncroExtensions_Delegate
    {
        static private readonly OperationCache<Operation<Delegate, FunctionSyncro>, Type, ContentsEnumerable<Type>> GET_INSTANCER = ReflectionCache.Get().NewOperationCache("GET_INSTANCER", delegate(Type delegate_type, ContentsEnumerable<Type> inner_parameter_types) {
            MethodInfo delegate_method = delegate_type.GetDelegateMethod();

            MethodInfo anonymous_method = null;
            Type anonymous_type = TypeCreator.CreateType("AnonymousType", TypeAttributes.Class, delegate (TypeBuilder builder) {
                FieldBuilder syncro = builder.CreateFieldBuilder<FunctionSyncro>("syncro", FieldAttributes.Private);

                builder.CreateConstructor(MethodAttributes.Public, delegate (ConstructorBuilderEX constructor) {
                    return new ILAssign(
                        constructor.GetILField(syncro),
                        constructor.GetTechnicalILParameter(0)
                    );
                }, typeof(FunctionSyncro));

                anonymous_method = builder.CreateMethod("AnonymousMethod", MethodAttributes.Private, delegate_method.ReturnType, delegate (MethodBuilderEX method) {
                    return new ILReturn(
                        method.GetILField(syncro)
                            .GetILInvoke(
                                "Execute",
                                new ILNewPopulatedArray(typeof(object),
                                    inner_parameter_types.ConvertToMatch(
                                        method.GetAllEffectiveILParameters(),
                                        (t, p) => t == p.GetValueType()
                                    ).Convert<ILParameter, ILValue>()
                                )
                            )
                    );
                }, delegate_method.GetEffectiveParameterTypes());
            });

            //TODO: CannotUnloadAppDomainException you make this more general within Salt>??????

            return anonymous_type.CreateDynamicMethodDelegate<Operation<Delegate, FunctionSyncro>>(delegate (ILValue syncro) {
                return new ILReturn(
                    new ILNew(delegate_type,
                        new ILNew(anonymous_type, syncro),
                        new ILFunctionPointer(anonymous_method)
                    )
                );
            });
        });

        static public Delegate CreateDelegate(this FunctionSyncro item, Type delegate_type)
        {
            return GET_INSTANCER
                .Fetch(delegate_type, new ContentsEnumerable<Type>(item.GetFunction().GetParameterTypes()))(item);
        }
        static public T CreateDelegate<T>(this FunctionSyncro item)
        {
            return item.CreateDelegate(typeof(T)).Convert<T>();
        }
    }
}