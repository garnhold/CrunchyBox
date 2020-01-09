using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class LayerEXExtensions
    {
        static private CacheManager CACHE_MANAGER = new CacheManager(Application.isPlaying);

        static private OperationCache<List<LayerEX>> GET_ALL_LAYERS = CACHE_MANAGER.NewOperationCache("GET_ALL_LAYERS", delegate() {
            return Ints.Range(0, 31, true)
                .Convert(n => new LayerEX(n))
                .Narrow(l => l.GetName().IsVisible())
                .ToList();
        });
        static public IEnumerable<LayerEX> GetAllLayers()
        {
            return GET_ALL_LAYERS.Fetch();
        }
    }
}