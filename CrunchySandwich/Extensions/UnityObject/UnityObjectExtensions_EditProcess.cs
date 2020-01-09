using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
    static public class UnityObjectExtensions_EditProcess
    {
        static public void EditProcess(this UnityEngine.Object item, Process process)
        {
            if (Application.isPlaying == false)
                process();
        }

        static public void EditProcess(this UnityEngine.Object item, string name, long delay, Process process)
        {
            if (Application.isPlaying == false)
                WorkSystem.GetInstance().ScheduleNamed(item, name, delay, process);
        }
    }
}