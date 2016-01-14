using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Radian Angle")]
public class RadianAngleSwipeDetection : SwipeGesture {

	public override void OnSwipeDetectedRadian (float angle)
	{
		Debug.Log("Radian Angle : " + angle);
	}

}
