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
        private float target_volume;
        private float volume_speed;

        private void Update()
        {
            AudioSource audio_source = this.FetchComponent<AudioSource>();

            audio_source.InterpolateVolume(target_volume, volume_speed * Time.deltaTime);

            if (audio_source.isPlaying == false || audio_source.volume <= 0.01f)
                this.DestroyGameObject();
        }

        public void Initialize(AudioClip c, float v = 1.0f)
        {
            AudioSource audio_source = this.FetchComponent<AudioSource>();

            audio_source.clip = c;
            audio_source.volume = v;
            audio_source.Play();
        }

        public void Fade(float speed)
        {
            target_volume = 0.0f;
            volume_speed = speed;
        }
    }
}