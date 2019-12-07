using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    [AssetClassCategory("Audio")]
    public class BurstAudioClip : CustomAsset
    {
        [SerializeField]private AudioClip audio;

        [SerializeField]private float volume = 1.0f;
        [SerializeField]private float volume_variance = 0.0f;

        [SerializeField]private float pitch = 1.0f;
        [SerializeField]private float pitch_variance = 0.0f;

        public void Initialize(AudioClip a)
        {
            audio = a;

            volume = 1.0f;
            volume_variance = 0.0f;

            pitch = 1.0f;
            pitch_variance = 0.0f;
        }

        public BurstAudioSource Deploy()
        {
            return new GameObject().AddComponent<BurstAudioSource>().Chain(s => s.Initialize(
                audio,
                RandFloat.GetVariance(volume, volume_variance),
                RandFloat.GetVariance(pitch, pitch_variance)
            ));
        }

    }
}