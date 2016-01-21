using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class DoubleTapDetectionExample : DoubleTapGesture {

		public override void DoubleTapDetected ()
		{
			Debug.Log("Double Tap!");
		}
	}
}