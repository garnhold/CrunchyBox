using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawTexture(Vector3 center, Vector2 size, Texture2D texture)
        {
            Gizmos.DrawGUITexture(
                RectExtensions.CreateCenterRect(
                    Camera.current.WorldToScreenPoint(center),
                    size
                ), 
                texture
            );
        }
        static public void DrawTexture(Vector3 position, float size, Texture2D texture)
        {
            GizmosExtensions.DrawTexture(
                position,
                new Vector2(size, texture.GetAspect() * size),
                texture
            );
        }

        static public void DrawSprite(Vector3 center, Vector2 size, Sprite sprite)
        {
            GizmosExtensions.DrawTexture(center, size, sprite.Sideload());
        }
        static public void DrawSprite(Vector3 center, float size, Sprite sprite)
        {
            GizmosExtensions.DrawSprite(
                center,
                new Vector2(size, sprite.GetTextureAspect() * size),
                sprite
            );
        }
    }
}