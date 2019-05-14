using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class LandPoint
    {
        private TerrainSample terrain_sample;

        private Pedia<LandRegionType, float> land_region_type_strengths;
        private Pedia<LandRegionType, float> land_region_type_presences;

        private Pedia<LandRegionSplat, float> land_region_splat_alpha;

        public LandPoint(TerrainSample s)
        {
            terrain_sample = s;

            land_region_type_strengths = new Pedia<LandRegionType, float>(0.0f);
            land_region_type_presences = new Pedia<LandRegionType, float>(0.0f);

            land_region_splat_alpha = new Pedia<LandRegionSplat, float>(0.0f);
        }

        public void PaintLandRegionTypeStrength(LandRegionType land_region_type, float strength = 1.0f)
        {
            land_region_type_strengths[land_region_type] += strength;
        }

        public void BuildLandRegionTypePresences()
        {
            float remaining_presence = 1.0f;

            foreach (KeyValuePair<LandRegionType, float> kvp in land_region_type_strengths.Sort(k => k.Key.GetGroundOffset()))
            {
                float current_presence = kvp.Value.BindBetween(0.0f, remaining_presence);

                land_region_type_presences[kvp.Key] = current_presence;
                remaining_presence -= current_presence;
            }
        }

        public void PaintLandRegionSplatAlpha(LandRegionType land_region_type, LandRegionSplat land_region_splat, float strength = 1.0f)
        {
            land_region_splat_alpha[land_region_splat] += land_region_type_presences[land_region_type] * strength;
        }

        public TerrainSample GetTerrainSample()
        {
            return terrain_sample;
        }

        public float GetLandRegionTypeStrength(LandRegionType land_region_type)
        {
            return land_region_type_strengths[land_region_type].BindBetween(0.0f, 1.0f);
        }

        public float GetLandRegionTypePresence(LandRegionType land_region_type)
        {
            return land_region_type_presences[land_region_type].BindBetween(0.0f, 1.0f);
        }

        public float GetLandRegionSplatAlpha(LandRegionSplat land_region_splat)
        {
            return land_region_splat_alpha[land_region_splat].BindBetween(0.0f, 1.0f);
        }
    }
}