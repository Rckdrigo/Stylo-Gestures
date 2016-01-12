﻿using UnityEngine;
using UnityEditor;

namespace StyloGestures{
	public class ScriptableAssetGenerator {

		[MenuItem("Assets/Create/Stylo Gestures/Swipe/Create swipe prefab")]
		public static void CreateSwipePrefab ()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/SwipeGesture"));
			prefab.name = "SwipeGesture";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Create new gesture parameters")]
		public static void CreateAsset ()
		{
			GestureParameters asset = ScriptableObject.CreateInstance<GestureParameters>();
			AssetDatabase.CreateAsset(asset, "Assets/NewGestureParameters.asset");
			AssetDatabase.SaveAssets();

			EditorUtility.FocusProjectWindow();
			Selection.activeObject = asset;
		}

	}
}
