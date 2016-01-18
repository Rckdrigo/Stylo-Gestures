using UnityEngine;
using System.Collections;
using StyloGestures;

[AddComponentMenu("StyloGestures/Tap Gesture/Double Tap")]
public class DoubleTapDetection : TapGesture {

	public override void DoubleTapDetected ()
	{
		Debug.Log("Double Tap!");
	}
}
