using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [RequireComponent(typeof(Terrain))]
    [AddComponentMenu("CrunchySandwich/Terrain/Land")]
    public class Land : MonoBehaviour
    {
        [SerializeField]private GameObject population_parent;
        [SerializeField]private List<LandRegionType> land_region_types;

        [ContextMenu("Build Land")]
        public void BuildLand()
        {
            TerrainData terrain_data = GetTerrainData();
            Palette<LandRegionSplat> palette = new Palette<LandRegionSplat>();

            IGrid<LandPoint> grid = GetTerrainData()
                .ConvertToSampleGridWithAlphaMapDimensions()
                .Convert(s => new LandPoint(s))
                .ToGrid();

            population_parent.DestroyChildrenAdvisory();

            land_region_types.Process(t => t.InitilizeLandRegion(this, palette));
            land_region_types.ProcessTillCompleteOrStagnated(t => t.BuildLandRegion(this, grid));

            grid.Process(p => p.BuildLandRegionTypePresences());

            land_region_types.Process(t => t.PaintLandRegion(this, grid));
            land_region_types.Process(t => t.PopulateLandRegion(this, grid, population_parent));

            float[,,] alpha_maps = new float[grid.GetHeight(), grid.GetWidth(), palette.GetNumberValues()];

            grid.ProcessWithIndexs((x, y, v) =>
                palette.Process(kvp =>
                    alpha_maps[y, x, kvp.Key] = kvp.Value.GetAlphaAt(v)
                )
            );

            terrain_data.splatPrototypes = palette.GetValues().Convert(s => s.GetSplatPrototype()).ToArray();
            terrain_data.SetAlphamaps(0, 0, alpha_maps);
        }

        public Terrain GetTerrain()
        {
            return GetComponent<Terrain>();
        }

        public TerrainData GetTerrainData()
        {
            return GetTerrain().terrainData;
        }

        public Vector3 GetCellSize()
        {
            return GetTerrainData().GetAlphaMapCellSize();
        }

        public Bounds GetCellBounds(int x, int y)
        {
            Vector3 size = GetCellSize();
            Vector3 center = new Vector3(size.x * (x + 0.5f), size.y * 0.5f, size.z * (y + 0.5f)) + transform.position;

            return new Bounds(center, size);
        }
    }
}