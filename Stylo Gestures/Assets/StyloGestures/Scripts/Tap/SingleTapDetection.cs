using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Tap Gesture/Single Tap")]
public class SingleTapDetection : TapGesture {

	public override void SingleTapDetected ()
	{ 
		Debug.Log("Simple tap!");
	}

}
