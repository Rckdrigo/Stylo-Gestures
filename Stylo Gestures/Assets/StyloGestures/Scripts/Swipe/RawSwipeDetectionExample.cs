using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures{

	public class RawSwipeDetectionExample : SwipeGesture {

		Text exampleLabel;

		void Start(){
			exampleLabel = GameObject.Find("ExampleText").GetComponent<Text>();
		}

		public override void OnSwipeRawDetected (Vector2 direction)
		{
			exampleLabel.text = "Swipe\nRaw direction: " + direction;	
		}
		
	}
}