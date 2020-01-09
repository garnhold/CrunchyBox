using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    [AddComponentMenu("CrunchySandwich/Prefab/PrefabRegion/PrefabRegion_PlanarMap")]
    public class PrefabRegion_PlanarMap : PrefabRegion
    {
        [SerializeField]private int resolution_x;
        [SerializeField]private int resolution_y;

        [AttachEditGadget("Paintable",
            new string[]{
                "MouseUp", "PopulateRegion",
            },
            new string[]{
                "position", "GetSpacarPosition()",
                "rotation", "GetSpacarQuaternion()",
                "size", "GetSize().GetPlanar()",
                "is_overlay_enabled", "IsOverlayEnabled()"
            }
        )]
        [SerializeField]private Texture2D texture;

        protected override void PopulateRegionInternal(float density)
        {
            Rect rect = GetBounds().GetPlanar();

            Vector2 cell_size = GetSize().GetComponentDivide(texture.GetSize());
            float cell_area = cell_size.x * cell_size.y;

            rect.ProcessCroppedGrid(cell_size, delegate(int x, int y, Rect sub_rect) {
                (texture.GetPixelAt(x, y).a * density).ProcessDensity(
                    cell_area, 
                    () => SpawnPrefab(RandVector2.GetWithinRect(sub_rect))
                );
            });
        }

        [ContextMenu("Clear Map")]
        public void ClearMap()
        {
            texture = Texture2DExtensions.CreateClear(resolution_x, resolution_y);
            texture.filterMode = FilterMode.Point;
        }

        public bool IsOverlayEnabled()
        {
            return true;
        }
    }
}