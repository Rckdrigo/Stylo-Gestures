using UnityEngine;
using System.Collections;

namespace StyloGestures{

	public class SingleTapDetectionExample : TapGesture {

		public override void SingleTapDetected ()
		{ 
			Debug.Log("Simple tap!");
		}

	}
}