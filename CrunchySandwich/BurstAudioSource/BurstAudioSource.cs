using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AddComponentMenu("")]
    public class BurstAudioSource : MonoBehaviour
    {
        private void Update()
        {
            if (this.FetchComponent<AudioSource>().isPlaying == false)
                this.DestroyGameObject();
        }

        public void Initialize(AudioClip c)
        {
            AudioSource audio_source = this.FetchComponent<AudioSource>();

            audio_source.clip = c;
            audio_source.Play();
        }
    }
}