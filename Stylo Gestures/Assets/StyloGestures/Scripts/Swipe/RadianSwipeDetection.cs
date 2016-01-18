using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Radian Angle")]
public class RadianSwipeDetection : SwipeGesture {

	public override void OnSwipeRadianDetected (float angle, float radius)
	{
		Debug.Log("Radian Angle : " + angle + " radius: " + radius);
	}

}
