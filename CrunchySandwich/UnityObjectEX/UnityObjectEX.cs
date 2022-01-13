using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
        public class MonoBehaviourEXPrefabLookup : Subsystem<MonoBehaviourEXPrefabLookup>
    {
        [SerializeFieldEX]private Dictionary<string, MonoBehaviourEX> items;
        
        public MonoBehaviourEXPrefabLookup()
        {
            items = new Dictionary<string, MonoBehaviourEX>();
        }
        
        public void Clear()
        {
            items.Clear();
        }
        
        public void Register(MonoBehaviourEX item)
        {
            items[item.GetReferenceId()] = item;
        }
        
        public MonoBehaviourEX Lookup(string id)
        {
            return items.GetValue(id);
        }
    }
    
    public class SaveStateMonoBehaviourEXPrefabReference
    {
        [SerializeFieldEX]private string prefab_id;

        static public implicit operator MonoBehaviourEX(SaveStateMonoBehaviourEXPrefabReference p)
        {
            return p.Resolve();
        }

        static public implicit operator SaveStateMonoBehaviourEXPrefabReference(MonoBehaviourEX o)
        {
            return o.IfNotNull(z => new SaveStateMonoBehaviourEXPrefabReference(z.GetReferenceId()));
        }

        public SaveStateMonoBehaviourEXPrefabReference(string id)
        {
            prefab_id = id;
        }

        public SaveStateMonoBehaviourEXPrefabReference() : this("") { }

        public MonoBehaviourEX Resolve()
        {
            return MonoBehaviourEXPrefabLookup.GetInstance().Lookup(prefab_id);
        }
    }

	public class MonoBehaviourEX : MonoBehaviour, ISerializationCallbackReceiver, SerializationCorruptable
    {
		[SerializeField][RecoveryField][AutoMultiline]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField][AutoMultiline]private string pack_error;
        [SerializeField][RecoveryField][AutoMultiline]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

		[SerializeField][HideInInspector]private string reference_id;
        
        protected virtual void LateConstruct() { }
        
		[RecoveryFunction]
		private void ForcePermissiveUnpackTyon()
		{
			UnpackTyon(TyonHydrationMode.Permissive);
		}

		private void PackTyon()
		{
			if (did_unpack_tyon_data || tyon_data.IsBlank())
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					TyonContext context = UnityTyonSettings.INSTANCE.CreateContext();

                    tyon_data = context.Serialize(this);
                    tyon_unity_objects = context.GetRegisteredExternalObjects()
						.Convert<object, UnityEngine.Object>()
						.ToList();

					pack_error = null;

					if (tyon_data != old_tyon_data)
						UnpackTyon();
				}
				catch(Exception ex)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					pack_error = ex.Message + "\n\n" + ex;
				}
			}
		}

		private void UnpackTyon(TyonHydrationMode mode = TyonHydrationMode.Strict)
		{
			if (tyon_data.IsVisible())
			{
				try
				{
					TyonContext context = UnityTyonSettings.INSTANCE.CreateContext(tyon_unity_objects.Convert<UnityEngine.Object, object>());

                    did_unpack_tyon_data = false;
                    
                    UnityTyonSettings.INSTANCE.FetchPrefabPusher(tyon_data)(this, context);
                    /*
                    context.CreateHydrater(mode)
                        .HydrateInto(
                            this,
                            UnityTyonSettings.INSTANCE.FetchPrefabTyonObject(tyon_data)
                        );
                    */

					did_unpack_tyon_data = true;
					unpack_error = null;
                    
				    PackTyon();
				}
				catch(Exception ex)
				{
					unpack_error = ex.Message + "\n\n" + ex;
				}
			}
		}

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
		    PackTyon();
        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
		    UnpackTyon();
            
            LateConstruct();
        }

		public bool IsSerializationCorrupt()
		{
			if (unpack_error.IsVisible())
				return true;

			if (pack_error.IsVisible())
				return true;

			return false;
		}

		public string GetReferenceId()
		{
			return reference_id;
		}
	}
    
    static public class MonoBehaviourEXExtensions
    {
        static public T GetPrefab<T>(this T item) where T : MonoBehaviourEX
        {
            return MonoBehaviourEXPrefabLookup.GetInstance().Lookup(item.GetReferenceId()).Convert<T>();
        }
        
        static public bool IsPrefab(this MonoBehaviourEX item)
        {
            if (item == item.GetPrefab())
                return true;
                
            return false;
        }
        static public bool IsInstance(MonoBehaviourEX item)
        {
            if (item.IsPrefab() == false)
                return true;
                
            return false;
        }
    }

    public class ScriptableObjectEXSofabLookup : Subsystem<ScriptableObjectEXSofabLookup>
    {
        [SerializeFieldEX]private Dictionary<string, ScriptableObjectEX> items;
        
        public ScriptableObjectEXSofabLookup()
        {
            items = new Dictionary<string, ScriptableObjectEX>();
        }
        
        public void Clear()
        {
            items.Clear();
        }
        
        public void Register(ScriptableObjectEX item)
        {
            items[item.GetReferenceId()] = item;
        }
        
        public ScriptableObjectEX Lookup(string id)
        {
            return items.GetValue(id);
        }
    }
    
    public class SaveStateScriptableObjectEXSofabReference
    {
        [SerializeFieldEX]private string prefab_id;

        static public implicit operator ScriptableObjectEX(SaveStateScriptableObjectEXSofabReference p)
        {
            return p.Resolve();
        }

        static public implicit operator SaveStateScriptableObjectEXSofabReference(ScriptableObjectEX o)
        {
            return o.IfNotNull(z => new SaveStateScriptableObjectEXSofabReference(z.GetReferenceId()));
        }

        public SaveStateScriptableObjectEXSofabReference(string id)
        {
            prefab_id = id;
        }

        public SaveStateScriptableObjectEXSofabReference() : this("") { }

        public ScriptableObjectEX Resolve()
        {
            return ScriptableObjectEXSofabLookup.GetInstance().Lookup(prefab_id);
        }
    }

	public class ScriptableObjectEX : ScriptableObject, ISerializationCallbackReceiver, SerializationCorruptable
    {
		[SerializeField][RecoveryField][AutoMultiline]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField][AutoMultiline]private string pack_error;
        [SerializeField][RecoveryField][AutoMultiline]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

		[SerializeField][HideInInspector]private string reference_id;
        
        protected virtual void LateConstruct() { }
        
		[RecoveryFunction]
		private void ForcePermissiveUnpackTyon()
		{
			UnpackTyon(TyonHydrationMode.Permissive);
		}

		private void PackTyon()
		{
			if (did_unpack_tyon_data || tyon_data.IsBlank())
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					TyonContext context = UnityTyonSettings.INSTANCE.CreateContext();

                    tyon_data = context.Serialize(this);
                    tyon_unity_objects = context.GetRegisteredExternalObjects()
						.Convert<object, UnityEngine.Object>()
						.ToList();

					pack_error = null;

					if (tyon_data != old_tyon_data)
						UnpackTyon();
				}
				catch(Exception ex)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					pack_error = ex.Message + "\n\n" + ex;
				}
			}
		}

		private void UnpackTyon(TyonHydrationMode mode = TyonHydrationMode.Strict)
		{
			if (tyon_data.IsVisible())
			{
				try
				{
					TyonContext context = UnityTyonSettings.INSTANCE.CreateContext(tyon_unity_objects.Convert<UnityEngine.Object, object>());

                    did_unpack_tyon_data = false;
                    
                    UnityTyonSettings.INSTANCE.FetchPrefabPusher(tyon_data)(this, context);
                    /*
                    context.CreateHydrater(mode)
                        .HydrateInto(
                            this,
                            UnityTyonSettings.INSTANCE.FetchPrefabTyonObject(tyon_data)
                        );
                    */

					did_unpack_tyon_data = true;
					unpack_error = null;
                    
				    PackTyon();
				}
				catch(Exception ex)
				{
					unpack_error = ex.Message + "\n\n" + ex;
				}
			}
		}

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
		    PackTyon();
        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
		    UnpackTyon();
            
            LateConstruct();
        }

		public bool IsSerializationCorrupt()
		{
			if (unpack_error.IsVisible())
				return true;

			if (pack_error.IsVisible())
				return true;

			return false;
		}

		public string GetReferenceId()
		{
			return reference_id;
		}
	}
    
    static public class ScriptableObjectEXExtensions
    {
        static public T GetSofab<T>(this T item) where T : ScriptableObjectEX
        {
            return ScriptableObjectEXSofabLookup.GetInstance().Lookup(item.GetReferenceId()).Convert<T>();
        }
        
        static public bool IsSofab(this ScriptableObjectEX item)
        {
            if (item == item.GetSofab())
                return true;
                
            return false;
        }
        static public bool IsInstance(ScriptableObjectEX item)
        {
            if (item.IsSofab() == false)
                return true;
                
            return false;
        }
    }

    public class TileBaseEXSofabLookup : Subsystem<TileBaseEXSofabLookup>
    {
        [SerializeFieldEX]private Dictionary<string, TileBaseEX> items;
        
        public TileBaseEXSofabLookup()
        {
            items = new Dictionary<string, TileBaseEX>();
        }
        
        public void Clear()
        {
            items.Clear();
        }
        
        public void Register(TileBaseEX item)
        {
            items[item.GetReferenceId()] = item;
        }
        
        public TileBaseEX Lookup(string id)
        {
            return items.GetValue(id);
        }
    }
    
    public class SaveStateTileBaseEXSofabReference
    {
        [SerializeFieldEX]private string prefab_id;

        static public implicit operator TileBaseEX(SaveStateTileBaseEXSofabReference p)
        {
            return p.Resolve();
        }

        static public implicit operator SaveStateTileBaseEXSofabReference(TileBaseEX o)
        {
            return o.IfNotNull(z => new SaveStateTileBaseEXSofabReference(z.GetReferenceId()));
        }

        public SaveStateTileBaseEXSofabReference(string id)
        {
            prefab_id = id;
        }

        public SaveStateTileBaseEXSofabReference() : this("") { }

        public TileBaseEX Resolve()
        {
            return TileBaseEXSofabLookup.GetInstance().Lookup(prefab_id);
        }
    }

	public class TileBaseEX : TileBase, ISerializationCallbackReceiver, SerializationCorruptable
    {
		[SerializeField][RecoveryField][AutoMultiline]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField][AutoMultiline]private string pack_error;
        [SerializeField][RecoveryField][AutoMultiline]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

		[SerializeField][HideInInspector]private string reference_id;
        
        protected virtual void LateConstruct() { }
        
		[RecoveryFunction]
		private void ForcePermissiveUnpackTyon()
		{
			UnpackTyon(TyonHydrationMode.Permissive);
		}

		private void PackTyon()
		{
			if (did_unpack_tyon_data || tyon_data.IsBlank())
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					TyonContext context = UnityTyonSettings.INSTANCE.CreateContext();

                    tyon_data = context.Serialize(this);
                    tyon_unity_objects = context.GetRegisteredExternalObjects()
						.Convert<object, UnityEngine.Object>()
						.ToList();

					pack_error = null;

					if (tyon_data != old_tyon_data)
						UnpackTyon();
				}
				catch(Exception ex)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					pack_error = ex.Message + "\n\n" + ex;
				}
			}
		}

		private void UnpackTyon(TyonHydrationMode mode = TyonHydrationMode.Strict)
		{
			if (tyon_data.IsVisible())
			{
				try
				{
					TyonContext context = UnityTyonSettings.INSTANCE.CreateContext(tyon_unity_objects.Convert<UnityEngine.Object, object>());

                    did_unpack_tyon_data = false;
                    
                    UnityTyonSettings.INSTANCE.FetchPrefabPusher(tyon_data)(this, context);
                    /*
                    context.CreateHydrater(mode)
                        .HydrateInto(
                            this,
                            UnityTyonSettings.INSTANCE.FetchPrefabTyonObject(tyon_data)
                        );
                    */

					did_unpack_tyon_data = true;
					unpack_error = null;
                    
				    PackTyon();
				}
				catch(Exception ex)
				{
					unpack_error = ex.Message + "\n\n" + ex;
				}
			}
		}

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
		    PackTyon();
        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
		    UnpackTyon();
            
            LateConstruct();
        }

		public bool IsSerializationCorrupt()
		{
			if (unpack_error.IsVisible())
				return true;

			if (pack_error.IsVisible())
				return true;

			return false;
		}

		public string GetReferenceId()
		{
			return reference_id;
		}
	}
    
    static public class TileBaseEXExtensions
    {
        static public T GetSofab<T>(this T item) where T : TileBaseEX
        {
            return TileBaseEXSofabLookup.GetInstance().Lookup(item.GetReferenceId()).Convert<T>();
        }
        
        static public bool IsSofab(this TileBaseEX item)
        {
            if (item == item.GetSofab())
                return true;
                
            return false;
        }
        static public bool IsInstance(TileBaseEX item)
        {
            if (item.IsSofab() == false)
                return true;
                
            return false;
        }
    }

}
