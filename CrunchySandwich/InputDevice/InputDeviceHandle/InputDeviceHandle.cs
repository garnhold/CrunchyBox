﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public class InputDeviceHandle
    {
        [SerializeField]private List<InputDeviceComponentHandle> component_handles;

        public void ProcessHandle(InputDeviceBase device, Process process)
        {
            component_handles.Process(h => h.EnterHandleSection(device));
                process();
            component_handles.Process(h => h.ExitHandleSection(device));
        }

        public T ProcessHandle<T>(InputDeviceBase device, Operation<T> operation)
        {
            T output = default(T);

            ProcessHandle(device, delegate() {
                output = operation();
            });

            return output;
        }
    }
}