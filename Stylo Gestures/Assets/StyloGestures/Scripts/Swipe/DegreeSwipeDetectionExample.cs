using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class DegreeSwipeDetectionExample : SwipeGesture {

		public override void OnSwipeDegreeDetected (float angle, float radius)
		{
			Debug.Log("Degree Angle : " + angle + " radius: " + radius);
		}
	}
}
