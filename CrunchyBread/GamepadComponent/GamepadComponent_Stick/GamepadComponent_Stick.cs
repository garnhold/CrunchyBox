using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class GamepadComponent_Stick : GamepadComponent, InputAtom_Stick
    {
        private InputAtom_Stick stick;

        private VectorF2 value;
        private float magnitude;
        private float angle_in_degrees;

        private VectorF2 frozen_value;
        private float frozen_magnitude;
        private float frozen_angle_in_degrees;

        private GamepadEventLog<GamepadStickZone> stick_zones;

        protected override void FreezeInternal()
        {
            frozen_value = value;
            frozen_magnitude = magnitude;
            frozen_angle_in_degrees = angle_in_degrees;
        }

        protected override void UpdateInternal()
        {
            value = stick.GetRawValue();
            magnitude = value.GetMagnitude();

            if (magnitude != 0.0f)
                angle_in_degrees = value.GetAngleInDegrees();

            if (magnitude < 0.5f)
                stick_zones.LogValue(GamepadStickZone.Center);
            else
            {
                stick_zones.LogValue(
                    angle_in_degrees.GetDegreeAngleClosestCardinalOrdinalDirection().GetGamepadStickZone()
                );
            }
        }

        protected override InputAtom GetAtom()
        {
            return stick;
        }

        public GamepadComponent_Stick(GamepadStickId i, InputAtomLockType l) : base(i, l)
        {
            value = VectorF2.ZERO;
            magnitude = 0.0f;
            angle_in_degrees = 0.0f;

            frozen_value = VectorF2.ZERO;
            frozen_magnitude = 0.0f;
            frozen_angle_in_degrees = 0.0f;

            stick_zones = new GamepadEventLog<GamepadStickZone>(64);
        }

        public void Initialize(InputAtom_Stick s)
        {
            stick = s;
        }

        public VectorF2 GetRawValue()
        {
            return stick.GetRawValue();
        }

        public VectorF2 GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }

        public float GetMagnitude()
        {
            return SwitchSharedFrozen(magnitude, frozen_magnitude);
        }

        public float GetAngleInDegrees()
        {
            return SwitchSharedFrozen(angle_in_degrees, frozen_angle_in_degrees);
        }

        public GamepadEventHistory<GamepadStickZone> GetHistory()
        {
            return SwitchSharedExclusive<GamepadEventHistory<GamepadStickZone>>(
                stick_zones,
                GamepadEventEmptyHistory<GamepadStickZone>.INSTANCE
            );
        }
    }
}