using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawText(Vector3 position, Quaternion rotation, string text, float size, TextAnchor text_anchor, Color color)
        {
            TextGenerationSettings settings = new TextGenerationSettings();

            settings.font = GUI.skin.font;
            settings.color = color;
            settings.fontStyle = FontStyle.Normal;

            settings.fontSize = 32;
            settings.lineSpacing = 1.0f;
            settings.scaleFactor = 1.0f;
            settings.textAnchor = text_anchor;

            settings.verticalOverflow = VerticalWrapMode.Overflow;
            settings.horizontalOverflow = HorizontalWrapMode.Overflow;
            settings.generateOutOfBounds = true;

            settings.font.material.SetPass(0);

            settings.CreateAndUseMesh(text, delegate(Mesh mesh) {
                Graphics.DrawMeshNow(
                    mesh,
                    Matrix4x4.TRS(
                        position,
                        rotation,
                        ((Vector2.one / settings.fontSize) * size).GetSpacar(1.0f)
                    )
                );
            });
        }
        static public void DrawText(Vector3 position, string text, float size, TextAnchor text_anchor, Color color)
        {
            DrawText(
                position,
                Quaternion.LookRotation(Camera.current.transform.forward),
                text,
                size,
                text_anchor,
                color
            );

        }
    }
}