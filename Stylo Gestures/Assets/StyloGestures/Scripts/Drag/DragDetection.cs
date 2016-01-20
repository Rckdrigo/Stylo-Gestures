using UnityEngine;
using System.Collections;
using StyloGestures;

public class DragDetection : DragGesture {

	public override void OnDraggingDetected (Vector2 screenPosition, Vector2 direction)
	{
		Debug.Log("Actual touch position : " + screenPosition + " direction: " + direction);
	}
}
