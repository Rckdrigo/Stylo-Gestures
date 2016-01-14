using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Normalized Vector")]
public class NormalizedSwipeDetection : SwipeGesture {

	public override void OnSwipeDetectedNormalized (Vector2 direction)
	{
		Debug.Log("Normalized direction " + direction);
	}

}
