using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;    
    [ExecuteAlways]
    public class RepresentationNode : MonoBehaviourEX
    {
        [SerializeFieldEX]private GameObject game_object;
        [SerializeFieldEX]private Scriptlet path;

        [InspectorDisplay]
        public object GetTarget()
        {
            return path.Invoke(game_object.Coalesce(gameObject));
        }
    }
}