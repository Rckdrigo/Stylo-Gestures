using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures{

	public class DoubleTapDetectionExample : DoubleTapGesture {

		Text exampleLabel;

		void Start(){
			exampleLabel = GameObject.Find("ExampleText").GetComponent<Text>();
		}

		public override void OnDoubleTapDetected ()
		{
			exampleLabel.text = "Double Tap!";
		}
	}
}