using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Simple")]
public class SimpleSwipeDetection : SwipeGesture {

	public override void OnSwipeSimpleDetected (SwipeDirection direction)
	{
		Debug.Log("Simple direction " + direction);
	}

}
