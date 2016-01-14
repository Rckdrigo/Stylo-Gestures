using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Degree Angle")]
public class DegreeAngleSwipeDetection : SwipeGesture {

	public override void OnSwipeDetectedDegree (float angle)
	{
		Debug.Log("Degree Angle : " + angle);
	}
}
