using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    static public partial class SerializedPropertyExtensions_Value
    {
		static public void ClearValue(this SerializedProperty item)
		{
			if(item.IsTypicalArray())
				item.ClearValue_Array();
			else
			{
				switch(item.propertyType)
				{
					case SerializedPropertyType.Generic:
						item.ClearValue_Generic();
						break;

					case SerializedPropertyType.Enum:
						item.ClearValue_Enum();
						break;
		
					case SerializedPropertyType.Boolean:
						item.boolValue = default(bool);
						break;
		
					case SerializedPropertyType.Integer:
						item.intValue = default(int);
						break;
		
					case SerializedPropertyType.Float:
						item.floatValue = default(float);
						break;
		
					case SerializedPropertyType.Character:
						item.stringValue = default(string);
						break;
		
					case SerializedPropertyType.String:
						item.stringValue = default(string);
						break;
		
					case SerializedPropertyType.Vector2:
						item.vector2Value = default(Vector2);
						break;
		
					case SerializedPropertyType.Vector3:
						item.vector3Value = default(Vector3);
						break;
		
					case SerializedPropertyType.Vector4:
						item.vector4Value = default(Vector4);
						break;
		
					case SerializedPropertyType.Rect:
						item.rectValue = default(Rect);
						break;
		
					case SerializedPropertyType.Bounds:
						item.boundsValue = default(Bounds);
						break;
		
					case SerializedPropertyType.Vector2Int:
						item.vector2IntValue = default(Vector2Int);
						break;
		
					case SerializedPropertyType.Vector3Int:
						item.vector3IntValue = default(Vector3Int);
						break;
		
					case SerializedPropertyType.RectInt:
						item.rectIntValue = default(RectInt);
						break;
		
					case SerializedPropertyType.BoundsInt:
						item.boundsIntValue = default(BoundsInt);
						break;
		
					case SerializedPropertyType.Quaternion:
						item.quaternionValue = default(Quaternion);
						break;
		
					case SerializedPropertyType.ArraySize:
						item.arraySize = default(int);
						break;
		
					case SerializedPropertyType.LayerMask:
						item.intValue = default(int);
						break;
		
					case SerializedPropertyType.Color:
						item.colorValue = default(Color);
						break;
		
					case SerializedPropertyType.Gradient:
						item.colorValue = default(Color);
						break;
		
					case SerializedPropertyType.ObjectReference:
						item.objectReferenceValue = default(UnityEngine.Object);
						break;
		
					case SerializedPropertyType.AnimationCurve:
						item.animationCurveValue = default(AnimationCurve);
						break;
						}
			}
		}

		static public void SetValue(this SerializedProperty item, object value)
		{
			if(item.IsTypicalArray())
				item.SetValue_Array(value);
			else
			{
				switch(item.propertyType)
				{
					case SerializedPropertyType.Generic:
						item.SetValue_Generic(value);
						break;

					case SerializedPropertyType.Enum:
						item.SetValue_Enum(value);
						break;
		
					case SerializedPropertyType.Boolean:
						item.boolValue = value.ConvertEX<bool>();
						break;
		
					case SerializedPropertyType.Integer:
						item.intValue = value.ConvertEX<int>();
						break;
		
					case SerializedPropertyType.Float:
						item.floatValue = value.ConvertEX<float>();
						break;
		
					case SerializedPropertyType.Character:
						item.stringValue = value.ConvertEX<string>();
						break;
		
					case SerializedPropertyType.String:
						item.stringValue = value.ConvertEX<string>();
						break;
		
					case SerializedPropertyType.Vector2:
						item.vector2Value = value.ConvertEX<Vector2>();
						break;
		
					case SerializedPropertyType.Vector3:
						item.vector3Value = value.ConvertEX<Vector3>();
						break;
		
					case SerializedPropertyType.Vector4:
						item.vector4Value = value.ConvertEX<Vector4>();
						break;
		
					case SerializedPropertyType.Rect:
						item.rectValue = value.ConvertEX<Rect>();
						break;
		
					case SerializedPropertyType.Bounds:
						item.boundsValue = value.ConvertEX<Bounds>();
						break;
		
					case SerializedPropertyType.Vector2Int:
						item.vector2IntValue = value.ConvertEX<Vector2Int>();
						break;
		
					case SerializedPropertyType.Vector3Int:
						item.vector3IntValue = value.ConvertEX<Vector3Int>();
						break;
		
					case SerializedPropertyType.RectInt:
						item.rectIntValue = value.ConvertEX<RectInt>();
						break;
		
					case SerializedPropertyType.BoundsInt:
						item.boundsIntValue = value.ConvertEX<BoundsInt>();
						break;
		
					case SerializedPropertyType.Quaternion:
						item.quaternionValue = value.ConvertEX<Quaternion>();
						break;
		
					case SerializedPropertyType.ArraySize:
						item.arraySize = value.ConvertEX<int>();
						break;
		
					case SerializedPropertyType.LayerMask:
						item.intValue = value.ConvertEX<int>();
						break;
		
					case SerializedPropertyType.Color:
						item.colorValue = value.ConvertEX<Color>();
						break;
		
					case SerializedPropertyType.Gradient:
						item.colorValue = value.ConvertEX<Color>();
						break;
		
					case SerializedPropertyType.ObjectReference:
						item.objectReferenceValue = value.ConvertEX<UnityEngine.Object>();
						break;
		
					case SerializedPropertyType.AnimationCurve:
						item.animationCurveValue = value.ConvertEX<AnimationCurve>();
						break;
						}
			}
		}

		static public object GetValue(this SerializedProperty item)
		{
			if(item.IsTypicalArray())
				return item.GetValue_Array();
			else
			{
				switch(item.propertyType)
				{
					case SerializedPropertyType.Generic: return item.GetValue_Generic();
					case SerializedPropertyType.Enum: return item.GetValue_Enum();
							case SerializedPropertyType.Boolean: return item.boolValue;
							case SerializedPropertyType.Integer: return item.intValue;
							case SerializedPropertyType.Float: return item.floatValue;
							case SerializedPropertyType.Character: return item.stringValue;
							case SerializedPropertyType.String: return item.stringValue;
							case SerializedPropertyType.Vector2: return item.vector2Value;
							case SerializedPropertyType.Vector3: return item.vector3Value;
							case SerializedPropertyType.Vector4: return item.vector4Value;
							case SerializedPropertyType.Rect: return item.rectValue;
							case SerializedPropertyType.Bounds: return item.boundsValue;
							case SerializedPropertyType.Vector2Int: return item.vector2IntValue;
							case SerializedPropertyType.Vector3Int: return item.vector3IntValue;
							case SerializedPropertyType.RectInt: return item.rectIntValue;
							case SerializedPropertyType.BoundsInt: return item.boundsIntValue;
							case SerializedPropertyType.Quaternion: return item.quaternionValue;
							case SerializedPropertyType.ArraySize: return item.arraySize;
							case SerializedPropertyType.LayerMask: return item.intValue;
							case SerializedPropertyType.Color: return item.colorValue;
							case SerializedPropertyType.Gradient: return item.colorValue;
							case SerializedPropertyType.ObjectReference: return item.objectReferenceValue;
							case SerializedPropertyType.AnimationCurve: return item.animationCurveValue;
						}
			}

			return null;
		}
		static public object GetValue(this SerializedProperty item, Type type)
		{
			return item.GetValue().ConvertEX(type);
		}
		static public T GetValue<T>(this SerializedProperty item)
		{
			return item.GetValue().ConvertEX<T>();
		}
    }
}

