using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class AudioClipExtensions_PlaySample
    {
        static public void PlaySample(this AudioClip item)
        {
            Type type = typeof(AudioImporter).Assembly.GetType("UnityEditor.AudioUtil");

            type.GetStaticMethod("StopAllClips")
                .Invoke(null, new object[] { });

            type.GetStaticMethod<AudioClip, int, bool>("PlayClip")
                .Invoke(null, new object[] { item, 0, false });
        }
    }
}