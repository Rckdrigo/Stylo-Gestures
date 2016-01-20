using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class LongPressDetectionExample : DragGesture {

		public override void OnLongPressDetected (Vector2 screenPosition)
		{
			Debug.Log("Actual touch position: " + screenPosition);
		}

	}
}