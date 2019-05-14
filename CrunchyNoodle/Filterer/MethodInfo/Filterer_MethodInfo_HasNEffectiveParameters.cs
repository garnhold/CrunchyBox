using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_HasNEffectiveParameters : Filterer_General<MethodInfo, IdentifiableInt>
    {
        static public readonly Filterer_MethodInfo_HasNEffectiveParameters INSTANCE_ONE = new Filterer_MethodInfo_HasNEffectiveParameters(1);
        static public readonly Filterer_MethodInfo_HasNEffectiveParameters INSTANCE_TWO = new Filterer_MethodInfo_HasNEffectiveParameters(2);
        static public readonly Filterer_MethodInfo_HasNEffectiveParameters INSTANCE_THREE = new Filterer_MethodInfo_HasNEffectiveParameters(3);
        static public readonly Filterer_MethodInfo_HasNEffectiveParameters INSTANCE_FOUR = new Filterer_MethodInfo_HasNEffectiveParameters(4);
        static public readonly Filterer_MethodInfo_HasNEffectiveParameters INSTANCE_FIVE = new Filterer_MethodInfo_HasNEffectiveParameters(5);

        public Filterer_MethodInfo_HasNEffectiveParameters(int i) : base(i)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            if (item.GetNumberEffectiveParameters() == GetId())
                return true;

            return false;
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasNEffectiveParameters(int n)
        {
            return new Filterer_MethodInfo_HasNEffectiveParameters(n);
        }

        static public Filterer<MethodInfo> HasOneEffectiveParameter()
        {
            return Filterer_MethodInfo_HasNEffectiveParameters.INSTANCE_ONE;
        }
        static public Filterer<MethodInfo> HasTwoEffectiveParameters()
        {
            return Filterer_MethodInfo_HasNEffectiveParameters.INSTANCE_TWO;
        }
        static public Filterer<MethodInfo> HasThreeEffectiveParameters()
        {
            return Filterer_MethodInfo_HasNEffectiveParameters.INSTANCE_THREE;
        }
        static public Filterer<MethodInfo> HasFourEffectiveParameters()
        {
            return Filterer_MethodInfo_HasNEffectiveParameters.INSTANCE_FOUR;
        }
        static public Filterer<MethodInfo> HasFiveEffectiveParameters()
        {
            return Filterer_MethodInfo_HasNEffectiveParameters.INSTANCE_FIVE;
        }
    }
}