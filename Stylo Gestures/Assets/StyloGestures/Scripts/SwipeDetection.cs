using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("Stylo Gesture/Swipe Detection")]
public class SwipeDetection : SwipeGesture {

//  Simple direction gives you 1 of the 4 values of the enumeration: Up, Down, Left, Right
	public override void OnSwipeDetectedSimple (SwipeDirection direction)
	{
		Debug.Log("Simple direction " + direction);
	}

//  Raw direction gives you the raw value of the swipe
	public override void OnSwipeDetectedRaw (Vector2 direction)
	{
		Debug.Log("Raw direction " + direction);	
	}

//  Normalized direction gives you the raw direction vector normalized (magnitude 1)
	public override void OnSwipeDetectedNormalized (Vector2 direction)
	{
		Debug.Log("Normalized direction " + direction);
	}

//  Radian Angle gives you the direction as a radian angle
	public override void OnSwipeDetectedRadianAngle (float angle)
	{
		Debug.Log("Radian Angle : " + angle);
	}

//  Degree Angle gives you the direction as a degree angle
	public override void OnSwipeDetectedDegreeAngle (float angle)
	{
		Debug.Log("Degree Angle : " + angle);
	}

}