﻿using System;
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

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

        public void OnBeforeSerialize()
        {
			if (did_unpack_tyon_data)
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					List<object> external_objects = new List<object>();

					tyon_data = Tyon.Serialize(this, UnityTyonSerializationSettings.INSTANCE, external_objects);
					tyon_unity_objects = external_objects.Convert<object, UnityEngine.Object>().ToList();
				}
				catch(Exception)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					throw;
				}
			}
        }

        public void OnAfterDeserialize()
        {
			did_unpack_tyon_data = false;

			List<object> external_objects = tyon_unity_objects.Convert<UnityEngine.Object, object>().ToList();

			Tyon.DeserializeInto(tyon_data, this, UnityTyonSerializationSettings.INSTANCE, external_objects);
			did_unpack_tyon_data = true;
        }
	}

	public class ScriptableObjectEX : ScriptableObject, ISerializationCallbackReceiver
    {
		[SerializeField][HideInInspector][Multiline(12)]private string tyon_data = "";
		[SerializeField][HideInInspector]private List<UnityEngine.Object> tyon_unity_objects;

		[SerializeField][HideInInspector]private bool did_unpack_tyon_data;

        public void OnBeforeSerialize()
        {
			if (did_unpack_tyon_data)
			{
				string old_tyon_data = tyon_data;
				List<UnityEngine.Object> old_tyon_unity_objects = tyon_unity_objects.ToList();

				try
				{
					List<object> external_objects = new List<object>();

					tyon_data = Tyon.Serialize(this, UnityTyonSerializationSettings.INSTANCE, external_objects);
					tyon_unity_objects = external_objects.Convert<object, UnityEngine.Object>().ToList();
				}
				catch(Exception)
				{
					tyon_data = old_tyon_data;
					tyon_unity_objects = old_tyon_unity_objects;

					throw;
				}
			}
        }

        public void OnAfterDeserialize()
        {
			did_unpack_tyon_data = false;

			List<object> external_objects = tyon_unity_objects.Convert<UnityEngine.Object, object>().ToList();

			Tyon.DeserializeInto(tyon_data, this, UnityTyonSerializationSettings.INSTANCE, external_objects);
			did_unpack_tyon_data = true;
        }
	}

}