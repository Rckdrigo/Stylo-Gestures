using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class DoubleTapDetectionExample : TapGesture {

		public override void DoubleTapDetected ()
		{
			Debug.Log("Double Tap!");
		}
	}
}