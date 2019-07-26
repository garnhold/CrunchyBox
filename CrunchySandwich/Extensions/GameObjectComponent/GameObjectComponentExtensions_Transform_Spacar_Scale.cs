using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Transform_Spacar_Scale
    {
		
		static public void ScaleSpacarScale(this GameObject item, float scale)
        {
            item.transform.ScaleSpacarScale(scale);
        }
        static public void ScaleLocalSpacarScale(this GameObject item, float scale)
        {
            item.transform.ScaleLocalSpacarScale(scale);
        }
		
		static public void ScaleSpacarScale(this Component item, float scale)
        {
            item.transform.ScaleSpacarScale(scale);
        }
        static public void ScaleLocalSpacarScale(this Component item, float scale)
        {
            item.transform.ScaleLocalSpacarScale(scale);
        }
	}
}