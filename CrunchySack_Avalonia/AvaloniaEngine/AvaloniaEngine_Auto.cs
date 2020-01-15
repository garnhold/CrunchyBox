using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class AvaloniaEngine : RepresentationEngine
    {
        public void AddInspectedComponentsForType(Type type)
        {
            Add(AvaloniaInstancers.Simple(type.Name, () => type.CreateInstance()));

            AddAttributeInfosForAvaloniaPropertys(type);
        }

        public void AddInspectedComponentsForTypes(IEnumerable<Type> types)
        {
            types.Process(t => AddInspectedComponentsForType(t));
        }
        public void AddInspectedComponentsForTypes(params Type[] types)
        {
            AddInspectedComponentsForTypes((IEnumerable<Type>)types);
        }

        public void AddAttributeInfosForAvaloniaPropertys(Type type)
        {
            Add(
                type.GetFilteredStaticFieldsOfType<AvaloniaProperty>(Filterer_FieldInfo.IsDeclaredWithin(type))
                    .Convert(f => f.Name)
                    .TryConvert((string s, out string p) => s.TryTrimSuffix("Property", out p))
                    .Convert(
                        s => type.GetVariableByPath(s)
                            .IfNotNull(v => AvaloniaInfos.AttributeLink(s.StyleAsVariableName(), v))
                    )
                    .SkipNull()
            );
        }
    }
}