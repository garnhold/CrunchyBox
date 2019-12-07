using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    using Bun;
    
    [ExecuteAlways]
    public abstract class RepresentationController : MonoBehaviourEX
    {
        private ComponentCache_Upward<RepresentationNode> representation_node;

        protected virtual void Start()
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