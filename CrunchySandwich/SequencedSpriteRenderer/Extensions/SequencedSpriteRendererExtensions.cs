using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class SequencedSpriteRendererExtensions
    {
        static public void AdjustSequenceValue(this SequencedSpriteRenderer item, float amount)
        {
            item.SetSequenceValue(item.GetSequenceValue() + amount);
        }

        static public void SetSequenceValue(this SequencedSpriteRenderer item, string name, float value)
        {
            item.SetSequence(name);
            item.SetSequenceValue(value);
        }

        static public void AdjustSequenceValue(this SequencedSpriteRenderer item, string name, float amount)
        {
            item.SetSequence(name);
            item.AdjustSequenceValue(amount);
        }
    }
}