using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/SequencedSpriteRenderer")]
    [RequireComponent(typeof(SpriteRenderer))]
    public class SequencedSpriteRenderer : MonoBehaviour
    {
        [SerializeField]private SequencedSprite sequenced_sprite;

        private float sequence_value;
        private SpriteSequence current_sequence;

        private void Start()
        {
            sequence_value = 0.0f;
            current_sequence = sequenced_sprite.GetDefaultSequence();
        }

        private void Update()
        {
            if (Application.isPlaying)
                GetComponent<SpriteRenderer>().sprite = current_sequence.GetFrameByValue(sequence_value);
            else
                GetComponent<SpriteRenderer>().sprite = sequenced_sprite.GetDefaultFrame();
        }

        public void SetSequenceValue(float value)
        {
            sequence_value = value;
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