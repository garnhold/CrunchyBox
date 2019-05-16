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
        public class TypeSerializerProp_Liaison : TypeSerializerProp
        {
            private FieldInfo liaison_field;

            private ILStatement GenerateInitialize(MethodBase method, ILValue type)
            {
                return new ILAssign(
                    GetILLiaisonField(method),
                    typeof(TypeSerializer).GetILInvoke("InstanceLiaison", type)
                );
            }

            private ILMethodInvokation GenerateReadDirect(MethodBase method, ILValue buffer)
            {
                return GetILLiaisonField(method).GetILInvoke(
                    "ReadUpdateInternalEX",
                    GetILProp(method),
                    buffer
                );
            }

            private ILMethodInvokation GenerateWriteDirect(MethodBase method, ILValue buffer)
            {
                return GetILLiaisonField(method).GetILInvoke(
                    "WriteUpdateInternalEX",
                    GetILProp(method),
                    buffer
                );
            }

            public TypeSerializerProp_Liaison(TypeBuilder type_builder, PropInfoEX p, TypeSerializer t) : base(p, t)
            {
                liaison_field = type_builder.CreateField(
                    p.GetPropType(),
                    p.GetName() + "_liaison",
                    FieldAttributesExtensions.PRIVATE
                );
            }

            public override ILStatement GenerateRead(MethodBase method, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(buffer.GetILInvoke("ReadType"), true);

                    block.AddStatement(
                        new ILIf(
                            GetILLiaisonField(method).GetILInvoke("ValidateEX", type).GetILIsFalse(),
                            GenerateInitialize(method, type)
                        )
                    );
                }
                else
                {
                    block.AddStatement(
                        new ILIf(
                            GetILLiaisonField(method).GetILIsNull(),
                            GenerateInitialize(method, GetPropType())
                        )
                    );
                }

                block.AddStatement(GenerateReadDirect(method, buffer));
                return block;
            }

            public override ILStatement GenerateWrite(MethodBase method, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(
                        GetILProp(method).GetILInvoke("GetTypeEX"),
                        true
                    );

                    block.AddStatement(
                        new ILIf(
                            GetILLiaisonField(method).GetILInvoke("ValidateEX").GetILIsFalse(),
                            GenerateInitialize(method, type)
                        )
                    );

                    block.AddStatement(buffer.GetILInvoke("WriteType", type));
                }
                else
                {
                    block.AddStatement(
                        new ILIf(
                            GetILLiaisonField(method).GetILIsNull(),
                            GenerateInitialize(method, GetPropType())
                        )
                    );
                }

                block.AddStatement(GenerateWriteDirect(method, buffer));
                return block;
            }

            public ILField GetILLiaisonField(MethodBase method)
            {
                return method.GetILField(liaison_field);
            }
        }
    }
}