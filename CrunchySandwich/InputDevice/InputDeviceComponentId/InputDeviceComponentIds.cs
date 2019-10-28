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
        [SerializeField]private string id;

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
        
    
		static private readonly OperationCache<List<InputDeviceComponentId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
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

        public InputDeviceComponentId(string i)
        {
            id = i;
        }

		public string GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCodeEX();
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

        public override string ToString()
        {
            return id;
        }
    }

	[Serializable]
    public struct InputDeviceAxisId
    {
        [SerializeField]private string id;

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
        
            
        static public implicit operator InputDeviceComponentId(InputDeviceAxisId id)
        {
            return new InputDeviceComponentId(id.id);
        }
    
		static private readonly OperationCache<List<InputDeviceAxisId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
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

        public InputDeviceAxisId(string i)
        {
            id = i;
        }

		public string GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCodeEX();
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

        public override string ToString()
        {
            return id;
        }
    }

	[Serializable]
    public struct InputDeviceButtonId
    {
        [SerializeField]private string id;

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
        
            
        static public implicit operator InputDeviceComponentId(InputDeviceButtonId id)
        {
            return new InputDeviceComponentId(id.id);
        }
    
		static private readonly OperationCache<List<InputDeviceButtonId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
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

        public InputDeviceButtonId(string i)
        {
            id = i;
        }

		public string GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCodeEX();
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

        public override string ToString()
        {
            return id;
        }
    }

	[Serializable]
    public struct InputDeviceStickId
    {
        [SerializeField]private string id;

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
        
            
        static public implicit operator InputDeviceComponentId(InputDeviceStickId id)
        {
            return new InputDeviceComponentId(id.id);
        }
    
		static private readonly OperationCache<List<InputDeviceStickId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
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

        public InputDeviceStickId(string i)
        {
            id = i;
        }

		public string GetValue()
		{
			return id;
		}

        public override int GetHashCode()
        {
            return id.GetHashCodeEX();
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

        public override string ToString()
        {
            return id;
        }
    }
}