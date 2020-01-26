using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RendererExtensions_Material
    {
        static public void AlterMaterialPropertys(this Renderer item, MaterialPropertyBlock block, Process<MaterialPropertyBlock> process)
        {
            item.GetPropertyBlock(block);
                process(block);
            item.SetPropertyBlock(block);
        }

        static public void AlterMaterialPropertys(this Renderer item, Process<MaterialPropertyBlock> process)
        {
            item.AlterMaterialPropertys(new MaterialPropertyBlock(), process);
        }

        static public void AlterMaterialPropertyFloat(this Renderer item, string name, float value)
        {
            item.AlterMaterialPropertys(delegate(MaterialPropertyBlock block) {
                block.SetFloat(name, value);
            });
        }

        static public void AlterMaterialPropertyColor(this Renderer item, string name, Color value)
        {
            item.AlterMaterialPropertys(delegate(MaterialPropertyBlock block) {
                block.SetColor(name, value);
            });
        }

        static public void AlterMaterialPropertyMatrix(this Renderer item, string name, Matrix4x4 value)
        {
            item.AlterMaterialPropertys(delegate(MaterialPropertyBlock block) {
                block.SetMatrix(name, value);
            });
        }

        static public void AlterMaterialPropertyTexture(this Renderer item, string name, Texture value)
        {
            item.AlterMaterialPropertys(delegate(MaterialPropertyBlock block) {
                block.SetTexture(name, value);
            });
        }

        static public void AlterMaterialPropertyVector(this Renderer item, string name, Vector4 value)
        {
            item.AlterMaterialPropertys(delegate(MaterialPropertyBlock block) {
                block.SetVector(name, value);
            });
        }
    }
}