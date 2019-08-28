using System;
using System.Text;
using System.Text.RegularExpressions;

using UnityEngine;
using UnityEngine.UI;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySandwich
{
    [ExecuteAlways]
    [AddComponentMenu("Utility/LinkedText")]
    public class LinkedText : MonoBehaviourEX
    {
        [SerializeFieldEX]private Methtoid getter;
        [SerializeFieldEX]private GameTimer refresh_timer = new GameTimer(0.050f, TimeType.Actual);
        [SerializeFieldEX][AutoMultiline]private string markup;

        private OperationCache<Variable, string> variable_cache;

        private void Start()
        {
            variable_cache = new OperationCache<Variable, string>("variable_cache", delegate(string path) {
                return getter.GetReturnType().GetVariableByPath(path);
            });
        }

        private void Update()
        {
            if (Application.isPlaying)
            {
                if (refresh_timer.Repeat())
                {
                    object target = getter.Invoke();

                    this.GetComponent<Text>().text = markup.RegexReplace("{([A-Za-z_\\.\\(\\)\\[\\]]+)}", delegate(Match match) {
                        return variable_cache.Fetch(match.Groups[1].Value).GetContents<string>(target);
                    });
                }
            }
            else
            {
                this.GetComponent<Text>().text = markup;
            }
        }
    }
}