using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class MotionConductorExtensions_Orders
    {
        static public ConductorOrder EaseTo(this MotionConductor item, float target, float duration, TimeType time_type, EaseOperation operation)
        {
            return new MotionConductorOrder_EaseTo(target, duration, time_type, item);
        }

        static public ConductorOrder Wait(this MotionConductor item, float duration, TimeType time_type)
        {
            return new ConductorOrder_Wait(new GameTimer(duration, time_type));
        }

        static public ConductorOrder WaitTill(this MotionConductor item, Operation<bool> operation)
        {
            return new ConductorOrder_Operation(operation);
        }
    }
}