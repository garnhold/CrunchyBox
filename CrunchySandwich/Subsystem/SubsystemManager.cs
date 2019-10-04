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

        public void Start()
        {
            Refresh();
            GetSubsystems().Process(s => s.Start());
        }

        public void StartInEditor()
        {
            Refresh();
            GetSubsystems().Process(s => s.StartInEditor());
        }

        public void Update()
        {
            GetSubsystems().Process(s => s.Update());
        }

        public void UpdateInEditor()
        {
            GetSubsystems().Process(s => s.UpdateInEditor());
        }

        public void Refresh()
        {
            subsystems = SubsystemExtensions_Resource.LoadSubsystemResources().ToDictionaryValues(s => s.GetType());
        }

        public Subsystem GetSubsystemInstance(Type type)
        {
            return subsystems.GetValue(type);
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