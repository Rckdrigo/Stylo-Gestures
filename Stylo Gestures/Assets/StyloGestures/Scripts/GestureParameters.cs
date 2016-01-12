using System;
using UnityEngine;

namespace StyloGestures{
	[Serializable]
	public class GestureParameters : ScriptableObject {

		[Header("Swipe Gestures")]

		[Range(0.00f,0.2f)] public float timePrecision = 0.045f;
		[Range(0,200)] public float lengthPrecision = 50f;

	}
}