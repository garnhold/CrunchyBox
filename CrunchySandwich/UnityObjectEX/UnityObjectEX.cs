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
		[SerializeField][RecoveryField][AutoMultiline]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField][AutoMultiline]private string pack_error;
        [SerializeField][RecoveryField][AutoMultiline]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

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

					pack_error = ex.ToString();
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
                    context.DeserializeInto(this, tyon_data, mode);

					if (ApplicationEX.GetInstance().IsEditing() && this.ShouldExecuteInEditMode())
						GetType().GetInstanceMethod("Start").IfNotNull(m => m.Invoke(this, null));

					did_unpack_tyon_data = true;
					unpack_error = null;

					PackTyon();
				}
				catch(Exception ex)
				{
					unpack_error = ex.ToString();
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
		[SerializeField][RecoveryField][AutoMultiline]private string tyon_data = "";
		[SerializeField][RecoveryField]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][RecoveryField][AutoMultiline]private string pack_error;
        [SerializeField][RecoveryField][AutoMultiline]private string unpack_error;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

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

					pack_error = ex.ToString();
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
                    context.DeserializeInto(this, tyon_data, mode);

					if (ApplicationEX.GetInstance().IsEditing() && this.ShouldExecuteInEditMode())
						GetType().GetInstanceMethod("Start").IfNotNull(m => m.Invoke(this, null));

					did_unpack_tyon_data = true;
					unpack_error = null;

					PackTyon();
				}
				catch(Exception ex)
				{
					unpack_error = ex.ToString();
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