using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    public abstract class RepresentationController : MonoBehaviourEX
    {
        private ComponentCache_Upward<RepresentationNode> representation_node;

        public RepresentationController()
        {
            representation_node = new ComponentCache_Upward<RepresentationNode>(this);
        }

        [InspectorDisplay]
        public object GetTarget()
        {
            return representation_node.GetComponent().IfNotNull(n => n.GetTarget());
        }
    }
}