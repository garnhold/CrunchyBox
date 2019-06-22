using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ScriptExecutionOrder(-10000)]
    public class ApplicationEXLiason : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            ApplicationEX.GetInstance().DrawGizmos();
        }

        private void Start()
        {
            ApplicationEX.GetInstance().Start();
        }

        private void Update()
        {
            ApplicationEX.GetInstance().Update();
        }
    }
}