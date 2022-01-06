using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/AnimatedSpriteRenderer")]
    [RequireComponent(typeof(SpriteRenderer))]
    public class AnimatedSpriteRenderer : MonoBehaviour
    {
        [SerializeField]private AnimatedSprite animated_sprite;
        [SerializeField]private GameStopwatch animation_time;
        [SerializeField]private bool use_random_offset;

        private SpriteAnimation current_animation;
        private float random_offset;

        private void Update()
        {
            if (Application.isPlaying)
            {
                GetComponent<SpriteRenderer>().sprite = current_animation
                    .GetFrameByTime(
                        animation_time.GetElapsedTimeInSeconds() +
                        use_random_offset.ConvertBool(random_offset)
                    );
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = animated_sprite.GetDefaultFrame();
            }
        }

        private void Start()
        {
            animation_time.Start();
            current_animation = animated_sprite.GetDefaultAnimation();

            random_offset = RandFloat.GetMagnitude(3600.0f);
        }

        public AnimatedSpriteRenderer()
        {
            animation_time = new GameStopwatch();
        }

        public void SetAnimatedSprite(AnimatedSprite s)
        {
            if (animated_sprite != s)
            {
                animated_sprite = s;
                current_animation = animated_sprite.GetDefaultAnimation();
            }
        }

        public void SetTimeType(TimeType t)
        {
            animation_time.SetTimeType(t);
        }

        public void SetRate(float rate)
        {
            animation_time.SetSpeed(rate);
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

        public TimeType GetTimeType()
        {
            return animation_time.GetTimeType();
        }

        public float GetRate()
        {
            return animation_time.GetSpeed();
        }
    }
}