using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class WPFEngine : RepresentationEngine
    {
        public void AddInspectedComponentsForType(Type type)
        {
            Add(WPFInstancers.Simple(type.Name, () => type.CreateInstance()));

            AddAttributeInfosForDependencyPropertys(type);
        }

        public void AddInspectedComponentsForTypes(IEnumerable<Type> types)
        {
            types.Process(t => AddInspectedComponentsForType(t));
        }
        public void AddInspectedComponentsForTypes(params Type[] types)
        {
            AddInspectedComponentsForTypes((IEnumerable<Type>)types);
        }

        public void AddAttributeInfosForDependencyPropertys(Type type)
        {
            Add(
                type.GetFilteredStaticFieldsOfType<DependencyProperty>(Filterer_FieldInfo.IsDeclaredWithin(type))
                    .Convert(f => f.Name)
                    .TryConvert((string s, out string p) => s.TryTrimSuffix("Property", out p))
                    .Convert(
                        s => type.GetVariableByPath(s)
                            .IfNotNull(v => WPFInfos.AttributeLink(s.StyleAsVariableName(), v))
                    )
                    .SkipNull()
            );
        }
    }
}