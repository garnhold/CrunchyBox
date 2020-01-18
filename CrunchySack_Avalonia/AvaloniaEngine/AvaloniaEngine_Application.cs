using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Platform;
using Avalonia.Controls.ApplicationLifetimes;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class AvaloniaEngine : RepresentationEngine
    {
        static private Window MAIN_WINDOW;
        static public Window GetMainWindow()
        {
            return MAIN_WINDOW;
        }

        private void StartApplication<APP_TYPE>(Operation<Window> operation) where APP_TYPE : Application, new()
        {
            AppBuilder.Configure<APP_TYPE>()
                .UsePlatformDetect()
                .AfterSetup(delegate (AppBuilder builder) {
                    MAIN_WINDOW = operation();

                    ((IClassicDesktopStyleApplicationLifetime)builder.Instance.ApplicationLifetime).MainWindow = MAIN_WINDOW;
                })
                .StartWithClassicDesktopLifetime(Empty.Array<string>());
        }

        public void StartApplication<APP_TYPE>(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT) where APP_TYPE : Application, new()
        {
            StartApplication<APP_TYPE>(() => CreateWindowRepresentation(target, layout));
        }
        public void StartApplication<APP_TYPE, T>(string layout = CmlLinkSource.DEFAULT_LAYOUT) where APP_TYPE : Application, new() where T : new()
        {
            StartApplication<APP_TYPE>(new T(), layout);
        }

        public void StartApplication<APP_TYPE>(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT) where APP_TYPE : Application, new()
        {
            StartApplication<APP_TYPE>(() => CreateWindowRepresentation(target, milliseconds, process, layout));
        }
        public void StartApplication<APP_TYPE, T>(T target, long milliseconds, Process<T> process, string layout = CmlLinkSource.DEFAULT_LAYOUT) where APP_TYPE : Application, new()
        {
            StartApplication<APP_TYPE>(target, milliseconds, () => process(target), layout);
        }
        public void StartApplication<APP_TYPE, T>(long milliseconds, Process<T> process, string layout = CmlLinkSource.DEFAULT_LAYOUT) where APP_TYPE : Application, new() where T : new()
        {
            StartApplication<APP_TYPE, T>(new T(), milliseconds, process, layout);
        }
    }
}