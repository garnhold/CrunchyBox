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
        public class TypeSerializerPropGroup
        {
            private Interval update_interval;

            private FieldInfo timer_field;
            private List<TypeSerializerProp> props;

            public TypeSerializerPropGroup(TypeBuilder type_builder, Interval ui, IEnumerable<TypeSerializerProp> p)
            {
                update_interval = ui;

                timer_field = type_builder.CreateFieldBuilder<Timer>("timer_" + update_interval.ToString().StyleAsVariableName(), FieldAttributesExtensions.PRIVATE);
                props = p.ToList();
            }

            public ILStatement GenerateRead(ILValue target, ILValue liaison, ILValue buffer)
            {
                return new ILIf(
                    buffer.GetILInvoke("ReadBoolean"),

                    props
                        .Convert(p => p.GenerateRead(target, liaison, buffer))
                        .ToBlock()
                );
            }

            public ILStatement GenerateWrite(ILValue target, ILValue field_update_interval, ILValue type_update_interval, ILValue liaison, ILValue to_return, ILValue buffer)
            {
                ILValue interval = update_interval.IsDefault()
                    .ConvertBool(
                        () => field_update_interval.GetILInvoke("GetWholeMilliseconds", type_update_interval),
                        () => (ILValue)update_interval.GetWholeMilliseconds()
                    );

                return new ILIf(
                    liaison.GetILField(timer_field).GetILInvoke("GetElapsedTimeInMilliseconds")
                        .GetILGreaterThanOrEqualTo(interval),
                    
                    new ILBlock(
                        buffer.GetILInvoke("WriteBoolean", true),
                        new ILAssign(to_return, true),
                        liaison.GetILField(timer_field).GetILInvoke("Restart"),
                        props
                            .Convert(p => p.GenerateWrite(target, liaison, buffer))
                            .ToBlock()
                    ),

                    buffer.GetILInvoke("WriteBoolean", false)
                );
            }

            public ILStatement GenerateConstructor(ILValue liaison)
            {
                return props
                    .Convert(p => p.GenerateConstructor(liaison))
                    .Append(new ILAssign(liaison.GetILField(timer_field), new ILNew(typeof(Timer))))
                    .Append(liaison.GetILField(timer_field).GetILInvoke("Start"))
                    .ToBlock();
            }

            public ILStatement GenerateUpdate(ILValue target, ILValue liaison)
            {
                return props
                    .Convert(p => p.GenerateUpdate(target, liaison))
                    .ToBlock();
            }

            public Interval GetUpdateInterval()
            {
                return update_interval;
            }
        }
    }
}