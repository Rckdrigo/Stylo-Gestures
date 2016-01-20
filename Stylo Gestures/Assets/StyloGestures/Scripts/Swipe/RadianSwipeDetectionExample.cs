using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class RadianSwipeDetectionExample : SwipeGesture {

		public override void OnSwipeRadianDetected (float angle, float radius)
		{
			Debug.Log("Radian Angle : " + angle + " radius: " + radius);
		}

	}
}
