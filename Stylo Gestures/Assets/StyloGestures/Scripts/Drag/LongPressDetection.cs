using UnityEngine;
using System.Collections;
using StyloGestures;

public class LongPressDetection : DragGesture {

	public override void OnLongPressDetected (Vector2 screenPosition)
	{
		Debug.Log("Actual touch position: " + screenPosition);
	}

}
