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
    [ExecuteAlways]
    public class RepresentationText : MonoBehaviourEX
    {
        [SerializeFieldEX]private GameTimer refresh_timer = new GameTimer(0.050f, TimeType.Actual);
        [SerializeFieldEX][AutoMultiline]private string markup;

        private ComponentCache_Upward<RepresentationNode> representation_node;

        private void Start()
        {
            representation_node = new ComponentCache_Upward<RepresentationNode>(this);
        }

        private void Update()
        {
            if (Application.isPlaying)
            {
                if (refresh_timer.Repeat())
                {
                    object target = representation_node.GetComponent().IfNotNull(n => n.GetTarget());

                    if(target != null)
                    {
                        this.GetComponent<Text>().text = markup.RegexReplace("{([A-Za-z_\\.\\(\\)\\[\\]]+)}", delegate(Match match) {
                            return target.GetVariableValueByPath<string>(match.Groups[1].Value);
                        });
                    }
                }
            }
            else
            {
                this.GetComponent<Text>().text = markup;
            }
        }
    }
}