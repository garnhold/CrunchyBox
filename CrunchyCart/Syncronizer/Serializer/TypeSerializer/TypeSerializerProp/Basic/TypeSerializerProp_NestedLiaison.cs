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

            protected override ILStatement GenerateReadInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(buffer.GetILInvoke("ReadType"), true);

                    block.AddStatement(
                        new ILIf(
                            liaison.GetILField(nested_liaison_field).GetILInvoke("ValidateEX", prop, type).GetILIsFalse(),
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

                block.AddStatement(liaison.GetILField(nested_liaison_field).GetILInvoke("Read", prop, buffer));
                return block;
            }

            protected override ILStatement GenerateWriteInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                ILBlock block = new ILBlock();

                if (IsPolymorphic())
                {
                    ILLocal type = block.CreateLocal(prop.GetILTypeEX(), true);

                    block.AddStatement(
                        new ILIf(
                            liaison.GetILField(nested_liaison_field).GetILInvoke("ValidateEX", prop).GetILIsFalse(),
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
                
                block.AddStatement(liaison.GetILField(nested_liaison_field).GetILInvoke("Write", prop, GetUpdateInterval(), buffer));
                return block;
            }

            protected override ILStatement GenerateUpdateInternal(ILValue prop, ILValue liaison)
            {
                return liaison.GetILField(nested_liaison_field).GetILInvoke("Update", prop);
            }

            public TypeSerializerProp_NestedLiaison(TypeBuilder type_builder, PropInfoEX p) : base(p)
            {
                nested_liaison_field = type_builder.CreateFieldBuilder<object>(
                    p.GetName() + "_liaison",
                    FieldAttributesExtensions.PRIVATE
                );
            }
        }
    }
}