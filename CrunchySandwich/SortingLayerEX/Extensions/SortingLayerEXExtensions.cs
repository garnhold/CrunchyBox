using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class SortingLayerEXExtensions
    {
        static private CacheManager CACHE_MANAGER = new CacheManager(Application.isPlaying);

        static private OperationCache<List<SortingLayerEX>> GET_ALL_SORTING_LAYERS = CACHE_MANAGER.NewOperationCache("GET_ALL_SORTING_LAYERS", delegate() {
            return SortingLayer.layers
                .Convert(l => new SortingLayerEX(l))
                .ToList();
        });
        static public IEnumerable<SortingLayerEX> GetAllSortingLayers()
        {
            return GET_ALL_SORTING_LAYERS.Fetch();
        }

        static private OperationCache<SortingLayerEX> GET_LOWEST_SORTING_LAYER = CACHE_MANAGER.NewOperationCache("GET_LOWEST_SORTING_LAYER", delegate() {
            return GetAllSortingLayers().FindLowestRated(l => l.GetValue());
        });
        static public SortingLayerEX GetLowestSortingLayer()
        {
            return GET_LOWEST_SORTING_LAYER.Fetch();
        }

        static private OperationCache<SortingLayerEX> GET_HIGHEST_SORTING_LAYER = CACHE_MANAGER.NewOperationCache("GET_HIGHEST_SORTING_LAYER", delegate() {
            return GetAllSortingLayers().FindHighestRated(l => l.GetValue());
        });
        static public SortingLayerEX GetHighestSortingLayer()
        {
            return GET_HIGHEST_SORTING_LAYER.Fetch();
        }
    }
}