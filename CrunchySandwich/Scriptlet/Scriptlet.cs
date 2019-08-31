using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class Scriptlet
    {
        [SerializeField][AutoMultiline]private string code;
        [SerializeFieldEX]private List<ScriptletArgument> arguments;

        public object Execute()
        {
            return ScriptletManager.GetInstance().Execute(code, arguments);
        }
    }
}