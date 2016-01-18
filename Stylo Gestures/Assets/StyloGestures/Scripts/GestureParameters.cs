using System;
using UnityEngine;

namespace StyloGestures{
	[Serializable]
	public class GestureParameters : ScriptableObject {

		[Header("Tap Gestures")]
		[Range(0.00f,0.2f)] public float tapDeltaTime = 0.15f;

		[Header("Swipe Gestures")]
		[Range(0.00f,0.2f)] public float swipeTimePrecision = 0.045f;
		[Range(0,200)] public float swipeLengthPrecision = 50f;

	}
}