using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class Texture2DExtensions_ModifySprites
    {
        static public void ModifySprites(this Texture2D item, Process<IEnumerable<SerializedProperty>> process)
        {
            item.ModifyAssetImporter(delegate (SerializedObject obj) {
                switch (obj.GetChildValue<SpriteImportMode>("m_SpriteMode"))
                {
                    case SpriteImportMode.Single: process(obj.ForceProperty("m_SpriteSheet").WrapAsEnumerable()); break;
                    case SpriteImportMode.Multiple: process(obj.ForceProperty("m_SpriteSheet.m_Sprites").GetArrayElements()); break;
                }
            });
        }

        static public void ModifyAllSprites(this Texture2D item, Process<SerializedProperty> process)
        {
            item.ModifySprites(ps => ps.Process(process));
        }

        static public void ModifySprite(this Texture2D item, string id, Process<SerializedProperty> process)
        {
            item.ModifySprites(delegate (IEnumerable<SerializedProperty> propertys) {
                propertys.Narrow(p => p.GetChildValue<string>("m_SpriteID") == id).Process(process);
            });
        }
        static public void ModifySprite(this Texture2D item, Sprite sprite, Process<SerializedProperty> process)
        {
            item.ModifySprite(sprite.GetSpriteId(), process);
        }
    }
}