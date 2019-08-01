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
        private Timer animation_time;

        private void Update()
        {
            float elapsed_time = animation_time.GetElapsedTimeInSeconds();

            this.FetchComponent<SpriteRenderer>().sprite = burst_sprite.GetFrameByTime(elapsed_time);

            if (elapsed_time >= burst_sprite.GetDuration())
                this.DestroyGameObject();
        }

        public void Initialize(BurstSprite s)
        {
            SpriteRenderer renderer = this.FetchComponent<SpriteRenderer>();

            burst_sprite = s;
            animation_time = new Timer(burst_sprite.GetTimeType().GetTimeSource()).StartAndGet();

            renderer.flipX = burst_sprite.IsFlipX();
            renderer.flipY = burst_sprite.IsFlipY();

            renderer.SetSortingLayerAndOrder(
                burst_sprite.GetSortingLayer(),
                burst_sprite.GetSortingOrder()
            );
        }
    }
}