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
	public class MonoBehaviourEX : MonoBehaviour, ISerializationCallbackReceiver
    {
		[SerializeField][HideInInspector][Multiline(12)]private string tyon_data = "";
		[SerializeField][HideInInspector]private List<UnityEngine.Object> tyon_unity_objects;

		protected virtual void Construct() { }

        public void OnBeforeSerialize()
        {
			List<object> external_objects = new List<object>();

			tyon_data = Tyon.Serialize(this, UnityTyonSerializationSettings.INSTANCE, external_objects);
			tyon_unity_objects = external_objects.Convert<object, UnityEngine.Object>().ToList();
        }

        public void OnAfterDeserialize()
        {
			List<object> external_objects = tyon_unity_objects.Convert<UnityEngine.Object, object>().ToList();

			Construct();
			Tyon.DeserializeInto(tyon_data, this, UnityTyonSerializationSettings.INSTANCE, external_objects);
        }
	}

	public class ScriptableObjectEX : ScriptableObject, ISerializationCallbackReceiver
    {
		[SerializeField][HideInInspector][Multiline(12)]private string tyon_data = "";
		[SerializeField][HideInInspector]private List<UnityEngine.Object> tyon_unity_objects;

		protected virtual void Construct() { }

        public void OnBeforeSerialize()
        {
			List<object> external_objects = new List<object>();

			tyon_data = Tyon.Serialize(this, UnityTyonSerializationSettings.INSTANCE, external_objects);
			tyon_unity_objects = external_objects.Convert<object, UnityEngine.Object>().ToList();
        }

        public void OnAfterDeserialize()
        {
			List<object> external_objects = tyon_unity_objects.Convert<UnityEngine.Object, object>().ToList();

			Construct();
			Tyon.DeserializeInto(tyon_data, this, UnityTyonSerializationSettings.INSTANCE, external_objects);
        }
	}

}