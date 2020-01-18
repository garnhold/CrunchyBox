using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Platform;

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