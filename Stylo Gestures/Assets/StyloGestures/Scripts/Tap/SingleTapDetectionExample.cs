using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures{

	public class SingleTapDetectionExample : TapGesture {

		Text exampleLabel;

		void Start(){
			exampleLabel = GameObject.Find("ExampleText").GetComponent<Text>();
		}

		public override void OnSingleTapDetected ()
		{ 
			exampleLabel.text = "Simple tap!";
		}

	}
}