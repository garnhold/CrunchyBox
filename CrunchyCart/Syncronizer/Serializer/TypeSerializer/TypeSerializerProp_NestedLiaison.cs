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
        public class TypeSerializerProp_NestedLiaison : TypeSerializerProp
        {
            private FieldInfo nested_liaison_field;

            private ILStatement GenerateInitialize(ILValue liaison, ILValue type)
            {
                return new ILAssign(
                    liaison.GetILField(nested_liaison_field),
                    typeof(TypeSerializer).GetILInvoke("InstanceLiaison", type)
                );
            }

            protected override ILStatement GenerateReadInternal(ILValue target, ILValue liaison, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(buffer.GetILInvoke("ReadType"), true);

                    block.AddStatement(
                        new ILIf(
                            liaison.GetILField(nested_liaison_field).GetILInvoke("ValidateEX", target).GetILIsFalse(),
                            GenerateInitialize(liaison, type)
                        )
                    );
                }
                else
                {
                    block.AddStatement(
                        new ILIf(
                            liaison.GetILField(nested_liaison_field).GetILIsNull(),
                            GenerateInitialize(liaison, GetPropType())
                        )
                    );
                }

                block.AddStatement(liaison.GetILField(nested_liaison_field).GetILInvoke("Read", target, buffer));
                return block;
            }

            protected override ILStatement GenerateWriteInternal(ILValue target, ILValue liaison, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(target.GetILTypeEX(), true);

                    block.AddStatement(
                        new ILIf(
                            liaison.GetILField(nested_liaison_field).GetILInvoke("ValidateEX", target).GetILIsFalse(),
                            GenerateInitialize(liaison, type)
                        )
                    );

                    block.AddStatement(buffer.GetILInvoke("WriteType", type));
                }
                else
                {
                    block.AddStatement(
                        new ILIf(
                            liaison.GetILField(nested_liaison_field).GetILIsNull(),
                            GenerateInitialize(liaison, GetPropType())
                        )
                    );
                }

                block.AddStatement(liaison.GetILField(nested_liaison_field).GetILInvoke("Write", target, buffer));
                return block;
            }

            public TypeSerializerProp_NestedLiaison(TypeBuilder type_builder, PropInfoEX p, TypeSerializer t) : base(p, t)
            {
                nested_liaison_field = type_builder.CreateField<object>(
                    p.GetName() + "_liaison",
                    FieldAttributesExtensions.PRIVATE
                );
            }
        }
    }
}