using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class ScriptletManager : Subsystem<ScriptletManager>
    {
        public object Execute(string code, IEnumerable<ScriptletArgument> arguments)
        {
            throw new NotImplementedException();
        }
    }
}