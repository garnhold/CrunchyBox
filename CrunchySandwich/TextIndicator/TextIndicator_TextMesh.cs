using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [RequireComponent(typeof(TextMesh))]
    public class TextIndicator_TextMesh : TextIndicator
    {
        public override void Initialize(Vector3 position, string text, float strength)
        {
            TextMesh text_mesh = this.GetComponent<TextMesh>();

            this.SetSpacarPosition(position);

            text_mesh.text = text;
            text_mesh.color = text_mesh.color.GetWithAlpha(strength);
        }
    }
}