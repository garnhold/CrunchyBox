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
        public class TypeSerializerDataTypeProp
        {
            private PropInfoEX target_prop;
            private FieldInfo liaison_field;

            public TypeSerializerDataTypeProp(TypeBuilder type_builder, PropInfoEX p)
            {
                target_prop = p;

                liaison_field = type_builder.CreateField(
                    target_prop.GetPropType(),
                    target_prop.GetName() + "_liaison",
                    FieldAttributesExtensions.PRIVATE
                );
            }

            public ILStatement GenerateInitialize(MethodBase method, ILValue type)
            {
                return new ILAssign(
                    method.GetILField(liaison_field),
                    typeof(TypeSerializer).GetILInvoke("InstanceLiaison", type)
                );
            }

            public ILStatement GenerateRead(MethodBase method, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(buffer.GetILInvoke("ReadType"), true);

                    block.AddStatement(
                        new ILIf(
                            method.GetILField(liaison_field).GetILInvoke("ValidateEX", type).GetILIsFalse(),
                            GenerateInitialize(method, type)
                        )
                    );
                }
                else
                {
                    block.AddStatement(
                        new ILIf(
                            method.GetILField(liaison_field).GetILIsNull(),
                            GenerateInitialize(method, target_prop.GetPropType())
                        )
                    );
                }

                block.AddStatement(GenerateReadDirect(method, buffer));
                return block;
            }
            public ILMethodInvokation GenerateReadDirect(MethodBase method, ILValue buffer)
            {
                return method.GetILField(liaison_field).GetInstanceILMethodInvokation(
                    "ReadUpdateInternalEX",
                    method.GetILProp(target_prop),
                    buffer
                );
            }

            public ILStatement GenerateWrite(MethodBase method, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(
                        method.GetILProp(target_prop).GetILInvoke("GetTypeEX"),
                        true
                    );

                    block.AddStatement(
                        new ILIf(
                            method.GetILField(liaison_field).GetILInvoke("ValidateEX").GetILIsFalse(),
                            GenerateInitialize(method, type)
                        )
                    );

                    block.AddStatement(buffer.GetILInvoke("WriteType", type));
                }
                else
                {
                    block.AddStatement(
                        new ILIf(
                            method.GetILField(liaison_field).GetILIsNull(),
                            GenerateInitialize(method, target_prop.GetPropType())
                        )
                    );
                }

                block.AddStatement(GenerateWriteDirect(method, buffer));
                return block;
            }
            public ILMethodInvokation GenerateWriteDirect(MethodBase method, ILValue buffer)
            {
                return method.GetILField(liaison_field).GetInstanceILMethodInvokation(
                    "WriteUpdateInternalEX",
                    method.GetILProp(target_prop),
                    buffer
                );
            }

            public bool IsPolymorphic()
            {
                if (target_prop.GetPropType().HasChildTypes())
                    return true;

                return false;
            }
        }
    }
}