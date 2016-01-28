using UnityEngine;
using UnityEditor;

namespace StyloGestures
{
	public class ScriptableAssetGenerator
	{

		[MenuItem("Assets/Create/Stylo Gestures/Create Double-Tap Gesture Event")]
		public static void CreateSimpleSwipePrefab()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("DoubleTapGestureEvent"));
			prefab.name = "DoubleTapGestureEvent";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Create Drag Gesture Event")]
		public static void CreateRawSwipePrefab()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("DragGestureEvent"));
			prefab.name = "DragGestureEvent";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Create Long-Press Gesture Event")]
		public static void CreateNormalizedSwipePrefab()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("LongPressGestureEvent"));
			prefab.name = "LongPressGestureEvent";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Create Swipe Gesture Event")]
		public static void CreateDegreeSwipePrefab()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("SwipeGestureEvent"));
			prefab.name = "SwipeGestureEvent";
		}

		[MenuItem("Assets/Create/Stylo Gestures/Create Tap Gesture Event")]
		public static void CreateRadianSwipePrefab()
		{
			Object prefab = MonoBehaviour.Instantiate(Resources.Load("Prefabs/TapGestureEvent"));
			prefab.name = "TapGestureEvent";
		}

	}
}
