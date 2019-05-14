using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyCane
{
    static public class ScaleTypes
    {
        static public readonly KeylessScale Major = new KeylessScale("2212221");
        static public readonly KeylessScale HarmonicMinor = new KeylessScale("2122131");
        static public readonly KeylessScale DoubleHarmonicMajor = new KeylessScale("1312131");
        static public readonly KeylessScale Chromatic = new KeylessScale("111111111111");
        static public readonly KeylessScale WholeTone = new KeylessScale("222222");
        static public readonly KeylessScale MinorPentatonic = new KeylessScale("32232");

        static public readonly KeylessScale Ionian = Major;
        static public readonly KeylessScale Dorian = Major.CreateMode(1);
        static public readonly KeylessScale Phrygian = Major.CreateMode(2);
        static public readonly KeylessScale Lydian = Major.CreateMode(3);
        static public readonly KeylessScale Mixolydian = Major.CreateMode(4);
        static public readonly KeylessScale Aeolian = Major.CreateMode(5);
        static public readonly KeylessScale NaturalMinor = Aeolian;
        static public readonly KeylessScale Locrian = Major.CreateMode(6);

        static public readonly KeylessScale PhrygianDominant = HarmonicMinor.CreateMode(4);
        static public readonly KeylessScale Freygish = PhrygianDominant;
        static public readonly KeylessScale RomanianMinor = HarmonicMinor.CreateMode(5);

        static public readonly KeylessScale Arabic = DoubleHarmonicMajor;
        static public readonly KeylessScale Byzantine = DoubleHarmonicMajor;
        static public readonly KeylessScale BhairavRaag = DoubleHarmonicMajor;
        static public readonly KeylessScale Lydian26 = DoubleHarmonicMajor.CreateMode(1);
        static public readonly KeylessScale Ultraphrygian = DoubleHarmonicMajor.CreateMode(2);
        static public readonly KeylessScale HungarianMinor = DoubleHarmonicMajor.CreateMode(3);
        static public readonly KeylessScale Oriental = DoubleHarmonicMajor.CreateMode(4);
        static public readonly KeylessScale Ionian25 = DoubleHarmonicMajor.CreateMode(5);
        static public readonly KeylessScale Locrian37 = DoubleHarmonicMajor.CreateMode(6);
        
        static public readonly KeylessScale MajorPentatonic = MinorPentatonic.CreateMode(1);
        static public readonly KeylessScale Egyption = MinorPentatonic.CreateMode(2);
        static public readonly KeylessScale Suspended = Egyption;
        static public readonly KeylessScale BluesMinor = MinorPentatonic.CreateMode(3);
        static public readonly KeylessScale ManGong = BluesMinor;
        static public readonly KeylessScale BluesMajor = MinorPentatonic.CreateMode(4);
        static public readonly KeylessScale Ritsusen = BluesMajor;
        static public readonly KeylessScale Yo = BluesMajor;
    }
}