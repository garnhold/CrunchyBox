using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Platform;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;

    public abstract class AvaloniaEngine : ApplicationRepresentationEngine<Window, PeriodicProcess_Avalonia>
    {
        private AppBuilder app_builder;

        protected override void AttachLinkSyncroDaemon(Window window, LinkSyncroDaemon daemon)
        {
            window.AttachLinkSyncroDaemon(daemon);
        }

        protected override void StartApplicationInternal(Operation<Window> operation)
        {
            app_builder
                .AfterSetup(delegate (AppBuilder builder) {
                    ((IClassicDesktopStyleApplicationLifetime)builder.Instance.ApplicationLifetime).MainWindow = operation();
                })
                .StartWithClassicDesktopLifetime(Empty.Array<string>());
        }

        public AvaloniaEngine(AppBuilder b)
        {
            app_builder = b;
        }

        public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : Control
        {
            this.AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.IsFocused == false);
        }
        public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, AvaloniaProperty property) where REPRESENTATION_TYPE : Control
        {
            AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, (s, t) => s.SetValue(property, t), s => s.GetValue(property).Convert<VALUE_TYPE>());
        }
        public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(AvaloniaProperty property) where REPRESENTATION_TYPE : Control
        {
            AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(property.Name, property);
        }

        public void AddAttributeFunction<REPRESENTATION_TYPE>(string n, RoutedEvent routed_event) where REPRESENTATION_TYPE : Control
        {
            this.AddAttributeFunction<REPRESENTATION_TYPE>(n, (e, s) => e.Register(routed_event, s, RoutingStrategies.Bubble));
            this.AddAttributeFunction<REPRESENTATION_TYPE>("preview_" + n, (e, s) => e.Register(routed_event, s, RoutingStrategies.Tunnel));
        }

        public void AddAvaloniaPropertyAttributeLinksForType(Type type)
        {
            type.GetFilteredStaticFieldsOfType<AvaloniaProperty>()
                .Convert(f => f.Name)
                .TryConvert((string s, out string p) => s.TryTrimSuffix("Property", out p))
                .Convert(s => type.GetVariableByPath(s))
                .SkipNull()
                .Process(v => this.AddAttributeLink(v.GetVariableName().StyleAsVariableName(), v));
            
        }
        public void AddAvaloniaPropertyAttributeLinksForType<T>()
        {
            AddAvaloniaPropertyAttributeLinksForType(typeof(T));
        }
    }
}