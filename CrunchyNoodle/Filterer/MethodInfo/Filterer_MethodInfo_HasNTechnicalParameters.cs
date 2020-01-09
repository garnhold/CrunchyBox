using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_HasNoTechnicalParameters : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_HasNoTechnicalParameters INSTANCE = new Filterer_MethodInfo_HasNoTechnicalParameters();

        private Filterer_MethodInfo_HasNoTechnicalParameters()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.HasNoTechnicalParameters();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasNoTechnicalParameters()
        {
            return Filterer_MethodInfo_HasNoTechnicalParameters.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_HasTechnicalParameters : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_HasTechnicalParameters INSTANCE = new Filterer_MethodInfo_HasTechnicalParameters();

        private Filterer_MethodInfo_HasTechnicalParameters()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.HasTechnicalParameters();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasTechnicalParameters()
        {
            return Filterer_MethodInfo_HasTechnicalParameters.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_HasNTechnicalParameters : Filterer_General<MethodInfo, IdentifiableInt>
    {
        static public readonly Filterer_MethodInfo_HasNTechnicalParameters INSTANCE_ONE = new Filterer_MethodInfo_HasNTechnicalParameters(1);
        static public readonly Filterer_MethodInfo_HasNTechnicalParameters INSTANCE_TWO = new Filterer_MethodInfo_HasNTechnicalParameters(2);
        static public readonly Filterer_MethodInfo_HasNTechnicalParameters INSTANCE_THREE = new Filterer_MethodInfo_HasNTechnicalParameters(3);
        static public readonly Filterer_MethodInfo_HasNTechnicalParameters INSTANCE_FOUR = new Filterer_MethodInfo_HasNTechnicalParameters(4);
        static public readonly Filterer_MethodInfo_HasNTechnicalParameters INSTANCE_FIVE = new Filterer_MethodInfo_HasNTechnicalParameters(5);

        public Filterer_MethodInfo_HasNTechnicalParameters(int i) : base(i)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            if (item.GetNumberTechnicalParameters() == GetId())
                return true;

            return false;
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasNTechnicalParameters(int n)
        {
            return new Filterer_MethodInfo_HasNTechnicalParameters(n);
        }

        static public Filterer<MethodInfo> HasOneTechnicalParameter()
        {
            return Filterer_MethodInfo_HasNTechnicalParameters.INSTANCE_ONE;
        }
        static public Filterer<MethodInfo> HasTwoTechnicalParameters()
        {
            return Filterer_MethodInfo_HasNTechnicalParameters.INSTANCE_TWO;
        }
        static public Filterer<MethodInfo> HasThreeTechnicalParameters()
        {
            return Filterer_MethodInfo_HasNTechnicalParameters.INSTANCE_THREE;
        }
        static public Filterer<MethodInfo> HasFourTechnicalParameters()
        {
            return Filterer_MethodInfo_HasNTechnicalParameters.INSTANCE_FOUR;
        }
        static public Filterer<MethodInfo> HasFiveTechnicalParameters()
        {
            return Filterer_MethodInfo_HasNTechnicalParameters.INSTANCE_FIVE;
        }
    }
}