using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AddComponentMenu("")]
    public class BurstSpriteRenderer : MonoBehaviour
    {
        private BurstSprite burst_sprite;
        private GameStopwatch animation_timer;

        private void Update()
        {
            float elapsed_time = animation_timer.GetElapsedTimeInSeconds();

            this.FetchComponent<SpriteRenderer>().sprite = burst_sprite.GetFrameByTime(elapsed_time);

            if (elapsed_time >= burst_sprite.GetDuration())
                this.DestroyGameObject();
        }

        public void Initialize(BurstSprite s)
        {
            SpriteRenderer renderer = this.FetchComponent<SpriteRenderer>();

            burst_sprite = s;
            animation_timer = new GameStopwatch(burst_sprite.GetTimeType()).StartAndGet();

            renderer.flipX = burst_sprite.IsFlipX();
            renderer.flipY = burst_sprite.IsFlipY();

            renderer.SetSortingLayerAndOrder(
                burst_sprite.GetSortingLayer(),
                burst_sprite.GetSortingOrder()
            );
        }
    }
}