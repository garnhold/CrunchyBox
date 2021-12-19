using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawTexture(Vector3 center, Vector2 size, Texture2D texture)
        {
            Mesh mesh = MeshExtensions.CreateCenterQuad(size);
            Material material = MaterialExtensions.CreateUnlitTransparentTextureMaterial(texture);

            material.SetPass(0);

            Graphics.DrawMeshNow(
                mesh,
                Matrix4x4.TRS(
                    center,
                    Quaternion.LookRotation(Camera.current.GetSpacarForward(), Vector3.up),
                    Vector3.one
                )
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
                new Vector2(size, sprite.GetAspect() * size),
                sprite
            );
        }
        static public void DrawSprite(Vector3 center, Sprite sprite)
        {
            GizmosExtensions.DrawSprite(center, sprite.GetWorldSize(), sprite);
        }
    }
}