using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySandwich
{

	[Serializable]
    public struct InputDeviceComponentId
    {
        [SerializeField]private int id;

        static public bool operator==(InputDeviceComponentId id1, InputDeviceComponentId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(InputDeviceComponentId id1, InputDeviceComponentId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }

		static private readonly OperationCache<List<InputDeviceComponentId>> GET_ALL = ReflectionCache.Get().NewOperationCache(delegate() {
			return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceComponentIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<InputDeviceComponentId>()
				.ToList();
        });
		static public IEnumerable<InputDeviceComponentId> GetComponents()
		{
			return GET_ALL.Fetch();
		}

        public InputDeviceComponentId(int i)
        {
            id = i;
        }

		public int GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            InputDeviceComponentId cast;

            if (obj.Convert<InputDeviceComponentId>(out cast))
            {
                if (cast == this)
                    return true;
            }

            return false;
        }

        static private readonly OperationCache<string, int> TO_STRING = ReflectionCache.Get().NewOperationCache(delegate(int id) {
            return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceComponentIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod<int>("GetName")
				.Invoke(null, new object[] { id }).ToString();
        });
        public override string ToString()
        {
            return TO_STRING.Fetch(id);
        }
    }

	[Serializable]
    public struct InputDeviceAxisId
    {
        [SerializeField]private int id;

        static public bool operator==(InputDeviceAxisId id1, InputDeviceAxisId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(InputDeviceAxisId id1, InputDeviceAxisId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }

		static private readonly OperationCache<List<InputDeviceAxisId>> GET_ALL = ReflectionCache.Get().NewOperationCache(delegate() {
			return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceAxisIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<InputDeviceAxisId>()
				.ToList();
        });
		static public IEnumerable<InputDeviceAxisId> GetAxiss()
		{
			return GET_ALL.Fetch();
		}

        public InputDeviceAxisId(int i)
        {
            id = i;
        }

		public int GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            InputDeviceAxisId cast;

            if (obj.Convert<InputDeviceAxisId>(out cast))
            {
                if (cast == this)
                    return true;
            }

            return false;
        }

        static private readonly OperationCache<string, int> TO_STRING = ReflectionCache.Get().NewOperationCache(delegate(int id) {
            return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceAxisIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod<int>("GetName")
				.Invoke(null, new object[] { id }).ToString();
        });
        public override string ToString()
        {
            return TO_STRING.Fetch(id);
        }
    }

	[Serializable]
    public struct InputDeviceButtonId
    {
        [SerializeField]private int id;

        static public bool operator==(InputDeviceButtonId id1, InputDeviceButtonId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(InputDeviceButtonId id1, InputDeviceButtonId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }

		static private readonly OperationCache<List<InputDeviceButtonId>> GET_ALL = ReflectionCache.Get().NewOperationCache(delegate() {
			return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceButtonIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<InputDeviceButtonId>()
				.ToList();
        });
		static public IEnumerable<InputDeviceButtonId> GetButtons()
		{
			return GET_ALL.Fetch();
		}

        public InputDeviceButtonId(int i)
        {
            id = i;
        }

		public int GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            InputDeviceButtonId cast;

            if (obj.Convert<InputDeviceButtonId>(out cast))
            {
                if (cast == this)
                    return true;
            }

            return false;
        }

        static private readonly OperationCache<string, int> TO_STRING = ReflectionCache.Get().NewOperationCache(delegate(int id) {
            return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceButtonIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod<int>("GetName")
				.Invoke(null, new object[] { id }).ToString();
        });
        public override string ToString()
        {
            return TO_STRING.Fetch(id);
        }
    }

	[Serializable]
    public struct InputDeviceStickId
    {
        [SerializeField]private int id;

        static public bool operator==(InputDeviceStickId id1, InputDeviceStickId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(InputDeviceStickId id1, InputDeviceStickId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }

		static private readonly OperationCache<List<InputDeviceStickId>> GET_ALL = ReflectionCache.Get().NewOperationCache(delegate() {
			return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceStickIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<InputDeviceStickId>()
				.ToList();
        });
		static public IEnumerable<InputDeviceStickId> GetSticks()
		{
			return GET_ALL.Fetch();
		}

        public InputDeviceStickId(int i)
        {
            id = i;
        }

		public int GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            InputDeviceStickId cast;

            if (obj.Convert<InputDeviceStickId>(out cast))
            {
                if (cast == this)
                    return true;
            }

            return false;
        }

        static private readonly OperationCache<string, int> TO_STRING = ReflectionCache.Get().NewOperationCache(delegate(int id) {
            return CrunchyNoodle.Types.GetFilteredTypes(
				Filterer_Type.IsNamed("InputDeviceStickIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod<int>("GetName")
				.Invoke(null, new object[] { id }).ToString();
        });
        public override string ToString()
        {
            return TO_STRING.Fetch(id);
        }
    }
}