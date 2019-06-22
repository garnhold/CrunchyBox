using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class AudioClipExtensions_Deploy
    {
        static public BurstAudioSource Deploy(this AudioClip item)
        {
            return new GameObject().AddComponent<BurstAudioSource>().Chain(s => s.Initialize(item));
        }

        static public BurstAudioSource Deploy(this AudioClip item, Vector3 position)
        {
            return item.Deploy().Chain(s => s.SetSpacarPosition(position));
        }
    }
}