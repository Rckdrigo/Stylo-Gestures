using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Degree Angle")]
public class DegreeSwipeDetection : SwipeGesture {

	public override void OnSwipeDegreeDetected (float angle, float radius)
	{
		Debug.Log("Degree Angle : " + angle + " radius: " + radius);
	}
}
