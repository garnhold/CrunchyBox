using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/AnimatedSpriteRenderer")]
    [RequireComponent(typeof(SpriteRenderer))]
    public class AnimatedSpriteRenderer : MonoBehaviour
    {
        [SerializeField]private AnimatedSprite animated_sprite;

        private FluxTimer animation_time;
        private SpriteAnimation current_animation;

        private void Start()
        {
            animation_time = new FluxTimer().StartAndGet();
            current_animation = animated_sprite.GetDefaultAnimation();
        }

        private void Update()
        {
            if (Application.isPlaying)
            {
                GetComponent<SpriteRenderer>().sprite = current_animation
                    .GetFrameByTime(animation_time.GetElapsedTimeInSeconds());
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = animated_sprite.GetDefaultFrame();
            }
        }

        public void SetRate(float rate)
        {
            animation_time.SetMultiplier(rate);
        }

        public void SetAnimation(string name)
        {
            SpriteAnimation animation = animated_sprite.GetAnimation(name);

            if (animation != current_animation)
            {
                current_animation = animation;
                animation_time.Reset();
            }
        }

        public bool Play()
        {
            return animation_time.Start();
        }

        public void Replay()
        {
            animation_time.Restart();
        }

        public bool Pause()
        {
            return animation_time.Pause();
        }

        public void StopClear()
        {
            animation_time.StopClear();
        }

        public float GetRate()
        {
            return animation_time.GetMultiplier();
        }
    }
}