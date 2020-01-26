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
    public class RepresentationController_Button : RepresentationController
    {
        [SerializeFieldEX]private Scriptlet scriptlet;

        protected override void Start()
        {
            base.Start();

            this.GetComponent<Button>().onClick.AddListener(delegate() {
                GetTarget().IfNotNull(t => scriptlet.Invoke(t));
            });
        }
    }
}