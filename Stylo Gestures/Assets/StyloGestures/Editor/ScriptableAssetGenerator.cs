﻿using UnityEngine;
using UnityEditor;

namespace StyloGestures{
	public class ScriptableAssetGenerator {

		[MenuItem("Stylo Gestures/Create new gesture parameters")]
		public static void CreateAsset ()
		{
			GestureParameters asset = ScriptableObject.CreateInstance<GestureParameters>();
			AssetDatabase.CreateAsset(asset, "Assets/NewGestureParameters.asset");
			AssetDatabase.SaveAssets();

			EditorUtility.FocusProjectWindow();
			Selection.activeObject = asset;
		}

		[MenuItem("Stylo Gestures/Create default gesture parameters")]
		public static void CreateDefaultAsset ()
		{
			GestureParameters asset = ScriptableObject.CreateInstance<GestureParameters>();
			AssetDatabase.CreateAsset(asset, "Assets/StyloGestures/Resources/DefaultSimpleGestureParameters.asset");
			AssetDatabase.SaveAssets();
			asset.hideFlags = HideFlags.NotEditable;
			EditorUtility.FocusProjectWindow();
			Selection.activeObject = asset;
		}
	}
}
