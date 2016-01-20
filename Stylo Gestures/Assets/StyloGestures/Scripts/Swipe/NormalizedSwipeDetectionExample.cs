using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class NormalizedSwipeDetectionExample : SwipeGesture {

		public override void OnSwipeNormalizedDetected (Vector2 direction)
		{
			Debug.Log("Normalized direction " + direction);
		}

	}
}
