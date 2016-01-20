using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class RawSwipeDetectionExample : SwipeGesture {

		public override void OnSwipeRawDetected (Vector2 direction)
		{
			Debug.Log("Raw direction " + direction);	
		}
		
	}
}