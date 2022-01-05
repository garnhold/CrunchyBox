using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/SequencedSpriteRenderer")]
    [RequireComponent(typeof(SpriteRenderer))]
    public class SequencedSpriteRenderer : MonoBehaviour
    {
        [SerializeField]private SequencedSprite sequenced_sprite;

        private float sequence_value;
        private Frame value_set_frame;
        private SpriteSequence current_sequence;

        private void Start()
        {
            sequence_value = 0.0f;
            current_sequence = sequenced_sprite.GetDefaultSequence();
        }

        private void Update()
        {
            if (Application.isPlaying)
            {
                SpriteSequenceFrame frame = current_sequence.GetFrameByValue(sequence_value);

                if (frame.IsSloped() && value_set_frame.IsNotRecent())
                    sequence_value += frame.GetSlope() * ActiveGameTime.GetDelta();

                GetComponent<SpriteRenderer>().sprite = frame.GetSprite();
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = sequenced_sprite.GetDefaultSprite();
            }
        }

        public void SetSequenceValue(float value)
        {
            if (value != sequence_value)
            {
                sequence_value = value;
                value_set_frame = Frame.GetCurrentFrame();
            }
        }

        public void SetSequence(string name)
        {
            SpriteSequence sequence = sequenced_sprite.GetSequence(name);

            if (sequence != current_sequence)
            {
                sequence_value = 0.0f;
                current_sequence = sequence;
            }
        }

        public float GetSequenceValue()
        {
            return sequence_value;
        }
    }
}