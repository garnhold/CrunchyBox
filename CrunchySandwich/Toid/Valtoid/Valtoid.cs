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
    public class Valtoid
    {
        [SerializeFieldEX]private GameObject target;
        [SerializeFieldEX]private Type target_type;
        [SerializeFieldEX]private string path;

        private string variable_path;
        private Variable variable;

        public Valtoid()
        {
        }

        public object GetValue()
        {
            if (path != variable_path)
            {
                variable = target_type.GetVariableByPath(path);
                variable_path = path;
            }

            return variable.GetContents(target.GetComponent(target_type));
        }
    }
}