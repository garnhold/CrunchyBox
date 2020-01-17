using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class AvaloniaEngine : RepresentationEngine
    {
        public void AddAvaloniaPropertyAttributeLinksForType(Type type)
        {
            Add(
                type.GetFilteredStaticFieldsOfType<AvaloniaProperty>()
                    .Convert(f => f.Name)
                    .TryConvert((string s, out string p) => s.TryTrimSuffix("Property", out p))
                    .Convert(
                        s => type.GetVariableByPath(s)
                            .IfNotNull(v => AvaloniaInfos.AttributeLink(s.StyleAsVariableName(), v))
                    )
                    .SkipNull()
            );
        }
        public void AddAvaloniaPropertyAttributeLinksForType<T>()
        {
            AddAvaloniaPropertyAttributeLinksForType(typeof(T));
        }
    }
}