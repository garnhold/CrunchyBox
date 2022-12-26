using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Experimental.U2D;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Rendering/BitmapSpriteShapeController")]
    public class BitmapSpriteShapeController : MonoBehaviour
    {
        [SerializeField]private Sprite sprite;
        [SerializeField][AssetField(true)]private SpriteVectorizer vectorizer;

        [SerializeField]private Texture2D fill;
        [SerializeField]private int fill_scale;
        [SerializeField]private Sprite[] edges;
        [SerializeField]private Sprite[] corners;

        [SerializeField]private int mode;
        [SerializeField]private float scale;

        [InspectorAction]
        private void Generate()
        {
            this.DestroyChildrenAdvisory();

            SpriteShapeParameters parameters = new SpriteShapeParameters() {
                fillScale = (uint)fill_scale,
                fillTexture = fill,
                transform = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, Vector3.one * scale),
                splineDetail = 4,
                adaptiveUV = false,
                angleThreshold = 90.0f,
                bevelCutoff = 5.0f,
                bevelSize = 1.0f,
                borderPivot = 0.0f,
                carpet = true,
                smartSprite = false,
                spriteBorders = false,
                stretchUV = false
            };

            AngleRangeInfo[] angle_range_info = new AngleRangeInfo[0];

            foreach (List<Vector2> points in vectorizer.VectorizeSprite(sprite))
            {
                SpriteShapeRenderer renderer = this.SpawnSingleComponentChildAtSelf<SpriteShapeRenderer>();

                SpriteShapeUtility.GenerateSpriteShape(
                    renderer,
                    parameters,
                    points
                        .Convert(p => new ShapeControlPoint() { 
                            mode = mode,
                            position = p,
                            leftTangent = p,
                            rightTangent = p
                        })
                        .ToArray(),
                    points
                        .Convert(p => new SpriteShapeMetaData() { 
                            spriteIndex = (uint)RandInt.GetIndex(edges.Length), 
                            height = 1.0f,
                            bevelCutoff = 5.0f,
                            bevelSize = 1.0f,
                            corner = false
                        })
                        .ToArray(),
                    angle_range_info,
                    edges,
                    corners
                );
            }
        }
    }
}