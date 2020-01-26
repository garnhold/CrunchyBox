using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [AddComponentMenu("Motion/MotionController_MaterialPropertyFloat")]
    public class MotionController_MaterialPropertyFloat : MotionController
    {
        [SerializeField]private string material_property;
        [SerializeFieldEX]private FloatRange range;

        protected override void UpdateInternal(float value)
        {
            this.GetComponent<MeshRenderer>().AlterMaterialPropertyFloat(material_property, value.ConvertFromOffsetToRange(range));
        }
    }
}