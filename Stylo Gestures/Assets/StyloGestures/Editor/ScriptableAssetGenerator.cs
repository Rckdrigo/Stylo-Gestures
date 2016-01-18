using UnityEngine;
using UnityEditor;

namespace StyloGestures{
	public class ScriptableAssetGenerator {

	#region Swipe Detection
		[MenuItem("Assets/Create/Stylo Gestures/Swipe/Create simple swipe detection prefab")]
		public static void CreateSimpleSwipePrefab ()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/SimpleSwipeDetection"));
			prefab.name = "SimpleSwipeDetection";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Swipe/Create raw vector swipe detection prefab")]
		public static void CreateRawSwipePrefab ()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/RawVectorSwipeDetection"));
			prefab.name = "RawVectorSwipeDetection";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Swipe/Create normalized vector swipe detection prefab")]
		public static void CreateNormalizedSwipePrefab ()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/NormalizedVectorSwipeDetection"));
			prefab.name = "NormalizedVectorSwipeDetection";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Swipe/Create degree angle swipe detection prefab")]
		public static void CreateDegreeSwipePrefab ()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/DegreeAngleSwipeDetection"));
			prefab.name = "DegreeAngleSwipeDetection";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Swipe/Create radian angle swipe detection prefab")]
		public static void CreateRadianSwipePrefab ()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/RadianAngleSwipeDetection"));
			prefab.name = "RadianAngleSwipeDetection";
		}

	#endregion


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
