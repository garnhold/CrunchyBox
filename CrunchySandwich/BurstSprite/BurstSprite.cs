using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AssetClassCategory("Sprite")]
    public class BurstSprite : CustomAsset
    {
        [SerializeField]private float duration;
        [SerializeField]private TimeType time_type;

        [SerializeField]private bool is_flip_x;
        [SerializeField]private bool is_flip_y;
        [SerializeField]private SortingLayerEX sorting_layer;
        [SerializeField]private int sorting_order;

        [SerializeField]private Sprite[] frames;

        [InspectorFunction]
        public void ReinitializeWithSprites(List<UnityEngine.Object> sprites)
        {
            Initialize(duration, sprites.Convert<UnityEngine.Object, Sprite>());
        }

        public void Initialize(float d, IEnumerable<Sprite> f)
        {
            duration = d;
            frames = f.ToArray();
        }
        public void Initialize(float d, params Sprite[] f)
        {
            Initialize(d, (IEnumerable<Sprite>)f);
        }

        public BurstSprite(float d, IEnumerable<Sprite> f)
        {
            duration = d;
            frames = f.ToArray();
        }

        public BurstSpriteRenderer Deploy()
        {
            return new GameObject().AddComponent<BurstSpriteRenderer>().Chain(r => r.Initialize(this));
        }

        public float GetDuration()
        {
            return duration;
        }

        public TimeType GetTimeType()
        {
            return time_type;
        }

        public bool IsFlipX()
        {
            return is_flip_x;
        }

        public bool IsFlipY()
        {
            return is_flip_y;
        }

        public int GetNumberFrames()
        {
            return frames.Length;
        }

        public Sprite GetFirstFrame()
        {
            return frames.GetFirst();
        }

        public Sprite GetLastFrame()
        {
            return frames.GetLast();
        }

        public Sprite GetFrameByIndex(int index)
        {
            return frames.GetLooped(index);
        }

        public Sprite GetFrameByTime(float seconds)
        {
            return frames.GetPercentCapped(seconds / duration);
        }

        public IEnumerable<Sprite> GetFrames()
        {
            return frames;
        }

        public SortingLayerEX GetSortingLayer()
        {
            return sorting_layer;
        }

        public int GetSortingOrder()
        {
            return sorting_order;
        }

    }
}