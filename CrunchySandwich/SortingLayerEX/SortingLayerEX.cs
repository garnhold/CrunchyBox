using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class SortingLayerEX
    {
        [SerializeField]private int id;

        static private CacheManager CACHE_MANAGER = new CacheManager(Application.isPlaying);

        static private OperationCache<List<SortingLayerEX>> GET_ALL_SORTING_LAYERS = CACHE_MANAGER.NewOperationCache(delegate() {
            return SortingLayer.layers
                .Convert(l => new SortingLayerEX(l))
                .ToList();
        });
        static public IEnumerable<SortingLayerEX> GetAllSortingLayers()
        {
            return GET_ALL_SORTING_LAYERS.Fetch();
        }

        static private OperationCache<SortingLayerEX> GET_LOWEST_SORTING_LAYER = CACHE_MANAGER.NewOperationCache(delegate() {
            return GetAllSortingLayers().FindLowestRated(l => l.GetValue());
        });
        static public SortingLayerEX GetLowestSortingLayer()
        {
            return GET_LOWEST_SORTING_LAYER.Fetch();
        }

        static private OperationCache<SortingLayerEX> GET_HIGHEST_SORTING_LAYER = CACHE_MANAGER.NewOperationCache(delegate() {
            return GetAllSortingLayers().FindHighestRated(l => l.GetValue());
        });
        static public SortingLayerEX GetHighestSortingLayer()
        {
            return GET_HIGHEST_SORTING_LAYER.Fetch();
        }

        public SortingLayerEX(int i)
        {
            id = i;
        }

        public SortingLayerEX(SortingLayer l) : this(l.id) { }
        public SortingLayerEX(string n) : this(SortingLayer.NameToID(n)) { }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return SortingLayer.IDToName(id);
        }

        public int GetValue()
        {
            return SortingLayer.GetLayerValueFromID(id);
        }

        public int GetOrder()
        {
            return GetValue() - GetLowestSortingLayer().GetValue();
        }

        public override bool Equals(object obj)
        {
            SortingLayerEX cast;

            if (obj.Convert<SortingLayerEX>(out cast))
            {
                if (cast.id == id)
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString()
        {
            return GetName();
        }
    }
}