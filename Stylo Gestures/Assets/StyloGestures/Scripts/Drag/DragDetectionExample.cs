using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class DragDetectionExample : DragGesture {

		public override void OnDraggingDetected (Vector2 screenPosition, Vector2 direction)
		{
			Debug.Log("Actual touch position : " + screenPosition + " direction: " + direction);
		}
	}
}