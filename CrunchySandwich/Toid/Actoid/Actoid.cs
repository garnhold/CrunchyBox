using System;
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
    public class Actoid
    {
        [SerializeFieldEX]private GameObject target;
        [SerializeFieldEX]private Type target_type;
        [SerializeFieldEX]private string path;

        private string action_path;
        private CrunchyNoodle.Action action;

        public Actoid()
        {
        }

        public void Execute()
        {
            if (path != action_path)
            {
                action = target_type.GetActionByPath(path);
                action_path = path;
            }

            action.Execute(target.GetComponent(target_type));
        }
    }
}