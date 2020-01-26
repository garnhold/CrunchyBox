using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Salt;    using Sandwich;
    
    static public class AudioClipExtensions_BurstAudioClip
    {
        static public BurstAudioClip CreateBurstAudioClip(this AudioClip audio_clip)
        {
            return CustomAssets.CreateExternalCustomAsset<BurstAudioClip>(
                Filename.SetExtension(audio_clip.GetAssetPath(), "asset"),
                s => s.Initialize(audio_clip)
            );
        }

        [MenuItem("Assets/AudioClip/Create/Burst")]
        static private void CreateBurstAudioClip()
        {
            ((AudioClip)Selection.activeObject).CreateBurstAudioClip();
        }

        [MenuItem("Assets/AudioClip/Create/Burst", true)]
        static private bool CreateBurstAudioClipValidate()
        {
            if (Selection.activeObject is AudioClip)
                return true;

            return false;
        }
    }
}