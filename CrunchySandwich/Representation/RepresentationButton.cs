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
    public class RepresentationButton : MonoBehaviourEX
    {
        [SerializeFieldEX]private Invoketoid invoketoid;

        private ComponentCache_Upward<RepresentationNode> representation_node;

        private void Start()
        {
            representation_node = new ComponentCache_Upward<RepresentationNode>(this);

            /*
            this.GetComponent<Button>().onClick.AddListener(delegate() {
                representation_node.GetComponent()
                    .IfNotNull(n => n.GetTarget())
                    .IfNotNull(t => invoketoid.Invoke())
            });
             */
        }
    }
}