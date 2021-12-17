using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;    
    [ExecuteInEditMode]
    public class RepresentationController_Text : RepresentationController
    {
        [SerializeFieldEX]private GameTimer refresh_timer = new GameTimer(0.050f, TimeType.Actual);
        [SerializeFieldEX][AutoMultiline]private string markup;

        private void Update()
        {
            if (refresh_timer.Repeat() || this.IsEditing())
            {
                object target = GetTarget();

                if (this.IsEditing() && target.IsNull())
                    this.GetComponent<Text>().text = markup;
                else
                {
                    this.GetComponent<Text>().text = markup.RegexReplace("{([A-Za-z_\\.\\(\\)\\[\\]]+)}", delegate(Match match) {
                        if (target.IsNotNull())
                            return target.GetVariableValueByPath<string>(match.Groups[1].Value);

                        return "";
                    });
                }
            }
        }
    }
}