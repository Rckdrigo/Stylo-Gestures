﻿using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Swipe Gesture/Raw Vector")]
public class RawSwipeDetection : SwipeGesture {

	public override void OnSwipeRawDetected (Vector2 direction)
	{
		Debug.Log("Raw direction " + direction);	
	}
	
}