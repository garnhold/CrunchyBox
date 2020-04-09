﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    using Salt;
    using Noodle;

	[Serializable]
    public struct GamepadComponentId
    {
        private string id;

        static public bool operator==(GamepadComponentId id1, GamepadComponentId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(GamepadComponentId id1, GamepadComponentId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }
        
    
		static private readonly OperationCache<List<GamepadComponentId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
			return Types.GetFilteredTypes(
				Filterer_Type.IsNamed("GamepadComponentIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<GamepadComponentId>()
				.ToList();
        });
		static public IEnumerable<GamepadComponentId> GetComponents()
		{
			return GET_ALL.Fetch();
		}

        public GamepadComponentId(string i)
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
            GamepadComponentId cast;

            if (obj.Convert<GamepadComponentId>(out cast))
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
    public struct GamepadAxisId
    {
        private string id;

        static public bool operator==(GamepadAxisId id1, GamepadAxisId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(GamepadAxisId id1, GamepadAxisId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }
        
            
        static public implicit operator GamepadComponentId(GamepadAxisId id)
        {
            return new GamepadComponentId(id.id);
        }
        
        static public explicit operator GamepadAxisId(GamepadComponentId id)
        {
            return new GamepadAxisId(id.GetValue());
        }
    
		static private readonly OperationCache<List<GamepadAxisId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
			return Types.GetFilteredTypes(
				Filterer_Type.IsNamed("GamepadAxisIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<GamepadAxisId>()
				.ToList();
        });
		static public IEnumerable<GamepadAxisId> GetAxiss()
		{
			return GET_ALL.Fetch();
		}

        public GamepadAxisId(string i)
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
            GamepadAxisId cast;

            if (obj.Convert<GamepadAxisId>(out cast))
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
    public struct GamepadButtonId
    {
        private string id;

        static public bool operator==(GamepadButtonId id1, GamepadButtonId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(GamepadButtonId id1, GamepadButtonId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }
        
            
        static public implicit operator GamepadComponentId(GamepadButtonId id)
        {
            return new GamepadComponentId(id.id);
        }
        
        static public explicit operator GamepadButtonId(GamepadComponentId id)
        {
            return new GamepadButtonId(id.GetValue());
        }
    
		static private readonly OperationCache<List<GamepadButtonId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
			return Types.GetFilteredTypes(
				Filterer_Type.IsNamed("GamepadButtonIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<GamepadButtonId>()
				.ToList();
        });
		static public IEnumerable<GamepadButtonId> GetButtons()
		{
			return GET_ALL.Fetch();
		}

        public GamepadButtonId(string i)
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
            GamepadButtonId cast;

            if (obj.Convert<GamepadButtonId>(out cast))
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
    public struct GamepadStickId
    {
        private string id;

        static public bool operator==(GamepadStickId id1, GamepadStickId id2)
        {
            if(id1.id == id2.id)
                return true;

            return false;
        }
        static public bool operator!=(GamepadStickId id1, GamepadStickId id2)
        {
            if(id1.id != id2.id)
                return true;

            return false;
        }
        
            
        static public implicit operator GamepadComponentId(GamepadStickId id)
        {
            return new GamepadComponentId(id.id);
        }
        
        static public explicit operator GamepadStickId(GamepadComponentId id)
        {
            return new GamepadStickId(id.GetValue());
        }
    
		static private readonly OperationCache<List<GamepadStickId>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
			return Types.GetFilteredTypes(
				Filterer_Type.IsNamed("GamepadStickIds"),
				Filterer_Type.IsStaticClass()
			).GetFirst()
				.GetStaticMethod("GetAll")
				.Invoke(null, new object[]{})
				.ToEnumerable<GamepadStickId>()
				.ToList();
        });
		static public IEnumerable<GamepadStickId> GetSticks()
		{
			return GET_ALL.Fetch();
		}

        public GamepadStickId(string i)
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
            GamepadStickId cast;

            if (obj.Convert<GamepadStickId>(out cast))
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