using System;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ApplicationEX
    {
        private bool is_playing;
        private Thread unity_main_thread;

        private List<Process> update_processes;
        private List<Process> update_in_editor_processes; //These will only be called if CrunchySandwichBag is also used

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
            return CrunchyNoodle.Types.GetFilteredTypes(
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
                ));
        }
        private IEnumerable<Process> GetApplicationEXMarkedTypeMethodProcesses(string name)
        {
            return GetApplicationEXMarkedTypeMethods(name)
                .Convert<MethodInfoEX, Process>(m => delegate() { m.Invoke(null, Empty.Array<object>()); });
        }

        private void UpdateGeneral()
        {
            is_playing = Application.isPlaying;

            deferred_processes.Process(p => p());
            deferred_processes.Clear();
        }

        private ApplicationEX()
        {
            is_playing = false;

            update_processes = GetApplicationEXMarkedTypeMethodProcesses("Update").ToList();
            update_in_editor_processes = GetApplicationEXMarkedTypeMethodProcesses("UpdateInEditor").ToList();

            draw_gizmos_processes = new List<Process>();
            deferred_processes = new List<Process>();
        }

        public void Start()
        {
            unity_main_thread = System.Threading.Thread.CurrentThread;

            GetApplicationEXMarkedTypeMethodProcesses("Start").Process(p => p());
        }

        public void Update()
        {
            update_processes.Process(p => p());
            UpdateGeneral();
        }

        public void UpdateInEditor()
        {
            update_in_editor_processes.Process(p => p());
            UpdateGeneral();
        }

        public void DrawGizmos()
        {
            draw_gizmos_processes.Process(p => p());
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
        public bool IsEditing()
        {
            if (IsPlaying() == false)
                return true;

            return false;
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