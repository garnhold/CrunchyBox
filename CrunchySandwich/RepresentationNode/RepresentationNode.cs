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
    [ExecuteAlways]
    public class RepresentationNode : MonoBehaviourEX
    {
        [SerializeFieldEX]private GameObject game_object;
        [SerializeFieldEX]private Scriptlet path;

        private ComponentCache_UpwardFromParent<RepresentationNode> parent;

        private void Start()
        {
            parent = new ComponentCache_UpwardFromParent<RepresentationNode>(this);
        }

        [InspectorDisplay]
        public object GetTarget()
        {
            return path.Invoke(
                game_object ?? parent.GetComponent().IfNotNull(p => p.GetTarget()) ?? this
            );
        }
    }
}