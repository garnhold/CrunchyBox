using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Spacar_MoveTowards
    {
		static public bool MoveTowardsSpacarPosition(this GameObject item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsSpacarPosition(target, amount);
        }
        static public bool MoveTowardsLocalSpacarPosition(this GameObject item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsLocalSpacarPosition(target, amount);
        }
        
        static public bool MoveTowardsSpacarPosition(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveTowardsSpacarPosition(target, amount);
        }
        static public bool MoveTowardsLocalSpacarPosition(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveTowardsLocalSpacarPosition(target, amount);
        }

        static public bool MoveTowardsSpacarScale(this GameObject item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsSpacarScale(target, amount);
        }
        static public bool MoveTowardsLocalSpacarScale(this GameObject item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsLocalSpacarScale(target, amount);
        }

		static public bool MoveTowardsSpacarScale(this GameObject item, float target, float amount)
        {
            return item.transform.MoveTowardsSpacarScale(target, amount);
        }
        static public bool MoveTowardsLocalSpacarScale(this GameObject item, float target, float amount)
        {
            return item.transform.MoveTowardsLocalSpacarScale(target, amount);
        }

		static public bool MoveTowardsSpacarPosition(this Component item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsSpacarPosition(target, amount);
        }
        static public bool MoveTowardsLocalSpacarPosition(this Component item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsLocalSpacarPosition(target, amount);
        }
        
        static public bool MoveTowardsSpacarPosition(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveTowardsSpacarPosition(target, amount);
        }
        static public bool MoveTowardsLocalSpacarPosition(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveTowardsLocalSpacarPosition(target, amount);
        }

        static public bool MoveTowardsSpacarScale(this Component item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsSpacarScale(target, amount);
        }
        static public bool MoveTowardsLocalSpacarScale(this Component item, Vector3 target, Vector3 amount)
        {
            return item.transform.MoveTowardsLocalSpacarScale(target, amount);
        }

		static public bool MoveTowardsSpacarScale(this Component item, float target, float amount)
        {
            return item.transform.MoveTowardsSpacarScale(target, amount);
        }
        static public bool MoveTowardsLocalSpacarScale(this Component item, float target, float amount)
        {
            return item.transform.MoveTowardsLocalSpacarScale(target, amount);
        }

	}
}