using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class SimpleSwipeDetectionExample : SwipeGesture {

		public override void OnSwipeSimpleDetected (SwipeDirection direction)
		{
			Debug.Log("Simple direction " + direction);
		}

	}
}