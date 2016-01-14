using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Simple")]
public class SimpleSwipeDetection : SwipeGesture {

	public override void OnSwipeDetectedSimple (SwipeDirection direction)
	{
		Debug.Log("Simple direction " + direction);
	}

}
