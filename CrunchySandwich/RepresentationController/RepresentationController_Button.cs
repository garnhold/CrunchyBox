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
    public class RepresentationController_Button : RepresentationController
    {
        [SerializeFieldEX]private Scriptlet scriptlet;

        private void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(delegate() {
                GetTarget().IfNotNull(t => scriptlet.Invoke(t));
            });
        }
    }
}