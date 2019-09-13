using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyRamen;

namespace CrunchySandwich
{
    public class TargetedScriptlet
    {
        [SerializeFieldEX]private GameObject target;
        [SerializeFieldEX]private Scriptlet scriptlet;

        public TargetedScriptlet()
        {
            scriptlet = new Scriptlet();
        }

        public object Invoke()
        {
            return scriptlet.Invoke(target);
        }
    }
}