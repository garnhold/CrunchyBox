using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    public class RepresentationNode : MonoBehaviourEX
    {
        [SerializeFieldEX]private GameObject game_object;
        [SerializeFieldEX]private string path;

        private string variable_path;
        private Type variable_declaring_type;

        private Variable variable;

        private ComponentCache_UpwardFromParent<RepresentationNode> parent;

        private object GetContents(object obj)
        {
            Type type = obj.GetTypeEX();

            if (type != variable_declaring_type || path != variable_path)
            {
                variable_path = path;
                variable_declaring_type = type;

                variable = variable_declaring_type.GetVariableByPath(variable_path);
            }

            return variable.GetContents(obj);
        }

        private void Start()
        {
            parent = new ComponentCache_UpwardFromParent<RepresentationNode>(this);
        }

        public object GetTarget()
        {
            return GetContents(
                game_object ?? parent.GetComponent().IfNotNull(p => p.GetTarget())
            );
        }
    }
}