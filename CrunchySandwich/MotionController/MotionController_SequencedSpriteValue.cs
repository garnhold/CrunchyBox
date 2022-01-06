using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [AddComponentMenu("Motion/MotionController_SequencedSpriteValue")]
    public class MotionController_SequencedSpriteValue : MotionController
    {
        [SerializeFieldEX]private FloatRange range;

        protected override void UpdateInternal(float value)
        {
            this.GetComponent<SequencedSpriteRenderer>().SetSequenceValue(value.ConvertFromOffsetToRange(range));
        }
    }
}