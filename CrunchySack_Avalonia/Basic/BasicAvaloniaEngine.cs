using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Platform;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;

    public class BasicAvaloniaEngine : AvaloniaEngine
    {
        static private BasicAvaloniaEngine INSTANCE;
        static public BasicAvaloniaEngine GetInstance()
        {
            return INSTANCE;
        }

        static public BasicAvaloniaEngine Initialize(AppBuilder builder)
        {
            INSTANCE = new BasicAvaloniaEngine(builder);

            MarkedMethods<BasicAvaloniaEngineInitilizerAttribute>.InvokeFilteredMarkedStaticMethods(INSTANCE);
            return GetInstance();
        }

        private BasicAvaloniaEngine(AppBuilder b) : base(b) { }
    }
}