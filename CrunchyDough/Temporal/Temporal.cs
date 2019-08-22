﻿using System;
using System.Reflection;

namespace CrunchyDough
{
    public interface Temporal
    {
        bool Start();
        bool Pause();

        bool IsRunning();
    }
}