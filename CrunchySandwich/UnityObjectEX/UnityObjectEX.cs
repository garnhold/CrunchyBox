using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;

namespace CrunchySandwich
{
	public class MonoBehaviourEX : MonoBehaviour, ISerializationCallbackReceiver, SerializationCorruptable
    {
		[SerializeField][RecoveryField][Multiline(12)]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField]private string pack_error;
        [SerializeField][RecoveryField]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

		private void PackTyon()
		{
			if (did_unpack_tyon_data || tyon_data.IsVisible() == false)
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					List<object> external_objects = new List<object>();

					tyon_data = Tyon.Serialize(this, UnityTyonSerializationSettings.INSTANCE, external_objects);
					tyon_unity_objects = external_objects.Convert<object, UnityEngine.Object>().ToList();

					pack_error = null;
				}
				catch(Exception ex)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					pack_error = ex.Message;
				}
			}
		}

		private void UnpackTyon()
		{
			if (tyon_data.IsVisible())
			{
				try
				{
					List<object> external_objects = tyon_unity_objects.Convert<UnityEngine.Object, object>().ToList();

					did_unpack_tyon_data = false;
					Tyon.DeserializeInto(tyon_data, this, UnityTyonSerializationSettings.INSTANCE, external_objects);

					did_unpack_tyon_data = true;
					unpack_error = null;
				}
				catch(Exception ex)
				{
					unpack_error = ex.Message;
				}
			}
		}

        public void OnBeforeSerialize()
        {
			PackTyon();
        }

        public void OnAfterDeserialize()
        {
			UnpackTyon();
        }

		public bool IsSerializationCorrupt()
		{
			if (unpack_error.IsVisible())
				return true;

			if (pack_error.IsVisible())
				return true;

			return false;
		}
	}

	public class ScriptableObjectEX : ScriptableObject, ISerializationCallbackReceiver, SerializationCorruptable
    {
		[SerializeField][RecoveryField][Multiline(12)]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField]private string pack_error;
        [SerializeField][RecoveryField]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

		private void PackTyon()
		{
			if (did_unpack_tyon_data || tyon_data.IsVisible() == false)
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					List<object> external_objects = new List<object>();

					tyon_data = Tyon.Serialize(this, UnityTyonSerializationSettings.INSTANCE, external_objects);
					tyon_unity_objects = external_objects.Convert<object, UnityEngine.Object>().ToList();

					pack_error = null;
				}
				catch(Exception ex)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					pack_error = ex.Message;
				}
			}
		}

		private void UnpackTyon()
		{
			if (tyon_data.IsVisible())
			{
				try
				{
					List<object> external_objects = tyon_unity_objects.Convert<UnityEngine.Object, object>().ToList();

					did_unpack_tyon_data = false;
					Tyon.DeserializeInto(tyon_data, this, UnityTyonSerializationSettings.INSTANCE, external_objects);

					did_unpack_tyon_data = true;
					unpack_error = null;
				}
				catch(Exception ex)
				{
					unpack_error = ex.Message;
				}
			}
		}

        public void OnBeforeSerialize()
        {
			PackTyon();
        }

        public void OnAfterDeserialize()
        {
			UnpackTyon();
        }

		public bool IsSerializationCorrupt()
		{
			if (unpack_error.IsVisible())
				return true;

			if (pack_error.IsVisible())
				return true;

			return false;
		}
	}

}