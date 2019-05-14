using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class JointMotor2DExtensions_With
    {
        static public JointMotor2D GetWithMaxTorque(this JointMotor2D item, float max_torque)
        {
            return new JointMotor2D() {
                maxMotorTorque = max_torque,
                motorSpeed = item.motorSpeed
            };
        }

        static public JointMotor2D GetWithSpeed(this JointMotor2D item, float speed)
        {
            return new JointMotor2D() {
                maxMotorTorque = item.maxMotorTorque,
                motorSpeed = speed
            };
        }
    }
}