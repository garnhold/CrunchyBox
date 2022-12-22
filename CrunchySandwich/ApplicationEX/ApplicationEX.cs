using System;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;

    public class ApplicationEX
    {
        private bool is_playing;
        private Thread unity_main_thread;

        private List<Process> start_processes;
        private List<Process> start_in_editor_processes; //These will only be called if Crunchy.SandwichBag is also used

        private List<Process> update_processes;
        private List<Process> update_in_editor_processes; //These will only be called if Crunchy.SandwichBag is also used

        private List<Process> draw_gizmos_processes;
        private List<Process> deferred_processes;

        static private ApplicationEX instance = new ApplicationEX();
        static public ApplicationEX GetInstance()
        {
            if (instance == null)
                instance = new ApplicationEX();

            return instance;
        }

        private IEnumerable<Type> GetApplicationEXMarkedTypes()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.HasCustomAttributeOfType<ApplicationEXSatelliteAttribute>(false),
                Filterer_Type.IsStaticClass()
            );
        }
        private IEnumerable<MethodInfoEX> GetApplicationEXMarkedTypeMethods(string name)
        {
            return GetApplicationEXMarkedTypes()
                .Convert(t => t.GetFilteredStaticMethods(
                    Filterer_MethodInfo.IsNamed(name),
                    Filterer_MethodInfo.HasNoReturn(),
                    Filterer_MethodInfo.HasNoEffectiveParameters(),
                    Filterer_MethodInfo.IsStaticMethod()
                ))
                .Flatten();
        }
        private IEnumerable<Process> GetApplicationEXMarkedTypeMethodProcesses(string name)
        {
            return GetApplicationEXMarkedTypeMethods(name)
                .Convert<MethodInfoEX, Process>(m => delegate() { m.Invoke(null, Empty.Array<object>()); });
        }

        private void StartUpdateGeneral()
        {
            is_playing = Application.isPlaying;
        }

        private void StartGeneral()
        {
            StartUpdateGeneral();

            unity_main_thread = System.Threading.Thread.CurrentThread;
        }

        private void UpdateGeneral()
        {
            StartUpdateGeneral();

            deferred_processes.ProcessSandboxed(p => p(), e => Debug.LogException(e));
            deferred_processes.Clear();
        }

        private ApplicationEX()
        {
            is_playing = false;
            unity_main_thread = null;

            start_processes = GetApplicationEXMarkedTypeMethodProcesses("Start").ToList();
            start_in_editor_processes = GetApplicationEXMarkedTypeMethodProcesses("StartInEditor").ToList();

            update_processes = GetApplicationEXMarkedTypeMethodProcesses("Update").ToList();
            update_in_editor_processes = GetApplicationEXMarkedTypeMethodProcesses("UpdateInEditor").ToList();

            draw_gizmos_processes = new List<Process>();
            deferred_processes = new List<Process>();
        }

        public void Start()
        {
            StartGeneral();
            start_processes.ProcessSandboxed(p => p(), e => Debug.LogException(e));
        }

        public void StartInEditor()
        {
            StartGeneral();
            start_in_editor_processes.ProcessSandboxed(p => p(), e => Debug.LogException(e));
        }

        public void Update()
        {
            UpdateGeneral();
            update_processes.ProcessSandboxed(p => p(), e => Debug.LogException(e));
        }

        public void UpdateInEditor()
        {
            UpdateGeneral();
            update_in_editor_processes.ProcessSandboxed(p => p(), e => Debug.LogException(e));
        }

        public void DrawGizmos()
        {
            draw_gizmos_processes.ProcessSandboxed(p => p(), e => Debug.LogException(e));
            draw_gizmos_processes.Clear();
        }

        public void RegisterDeferredProcess(Process process)
        {
            deferred_processes.Add(process);
        }

        public void RegisterDrawGizmos(Process process)
        {
            draw_gizmos_processes.Add(process);
        }

        public bool IsPlaying()
        {
            return is_playing;
        }

        public bool IsUnityMainThread()
        {
            if (System.Threading.Thread.CurrentThread.Equals(GetUnityMainThread()))
                return true;

            return false;
        }

        public Thread GetUnityMainThread()
        {
            return unity_main_thread;
        }
    }
}