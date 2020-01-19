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
    
    public abstract class WPFEngine : ApplicationRepresentationEngine<Window, PeriodicProcess_WPF>
    {
        protected override void AttachLinkSyncroDaemon(Window window, LinkSyncroDaemon daemon)
        {
            window.AttachLinkSyncroDaemon(daemon);
        }

        protected override void StartApplicationInternal(Operation<Window> operation)
        {
            Application.Current.Run(operation());
        }

        public WPFEngine()
        {
            if (Application.Current == null)
                new Application();

        }

        public void AddInspectedComponentsForType(Type type)
        {
            this.AddSimpleInstancer(type);

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
            type.GetFilteredStaticFieldsOfType<DependencyProperty>(Filterer_FieldInfo.IsDeclaredWithin(type))
                .Convert(f => f.Name)
                .TryConvert((string s, out string p) => s.TryTrimSuffix("Property", out p))
                .Convert(p => type.GetVariableByPath(p))
                .SkipNull()
                .Process(v => this.AddAttributeLink(v.GetVariableName().StyleAsVariableName(), v));
        }
    }
}