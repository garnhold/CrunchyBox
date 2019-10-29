using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    [ApplicationEXSatellite]
    static public class SubsystemManagerSatellite
    {
        static private void Start()
        {
            SubsystemManager.GetInstance().Start();
        }

        static private void StartInEditor()
        {
            SubsystemManager.GetInstance().StartInEditor();
        }

        static private void Update()
        {
            SubsystemManager.GetInstance().Update();
        }

        static private void UpdateInEditor()
        {
            SubsystemManager.GetInstance().UpdateInEditor();
        }
    }

    public class SubsystemManager
    {
        private Dictionary<Type, Subsystem> subsystems;

        static private SubsystemManager instance;
        static public SubsystemManager GetInstance()
        {
            if (instance == null)
                instance = new SubsystemManager();

            return instance;
        }

        public SubsystemManager()
        {
            subsystems = new Dictionary<Type, Subsystem>();
        }

        public void Start()
        {
            Refresh();
            GetSubsystems().ProcessSandboxed(s => s.Start(), e => Debug.LogException(e));
        }

        public void StartInEditor()
        {
            Refresh();
            GetSubsystems().ProcessSandboxed(s => s.StartInEditor(), e => Debug.LogException(e));
        }

        public void Update()
        {
            GetSubsystems().ProcessSandboxed(s => s.Update(), e => Debug.LogException(e));
        }

        public void UpdateInEditor()
        {
            GetSubsystems().ProcessSandboxed(s => s.UpdateInEditor(), e => Debug.LogException(e));
        }

        public void Refresh()
        {
            subsystems.Set(
                SubsystemExtensions_Resource.LoadSubsystemResources().ConvertToValueOfPair(s => s.GetType())
            );
        }

        public Subsystem GetSubsystemInstance(Type type)
        {
            return subsystems.GetOrCreateValue(type, t => SubsystemExtensions_Resource.LoadSubsystemResource(t));
        }
        public T GetSubsystemInstance<T>() where T : Subsystem
        {
            return GetSubsystemInstance(typeof(T)).Convert<T>();
        }

        public IEnumerable<Subsystem> GetSubsystems()
        {
            return subsystems.Values;
        }
    }
}