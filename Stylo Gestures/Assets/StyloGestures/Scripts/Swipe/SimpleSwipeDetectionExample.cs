using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures{

	public class SimpleSwipeDetectionExample : SwipeGesture {

		Text exampleLabel;

		void Start(){
			exampleLabel = GameObject.Find("ExampleText").GetComponent<Text>();
		}

		public override void OnSwipeSimpleDetected (SwipeDirection direction)
		{
			exampleLabel.text = "Swipe\nSimple direction: " + direction;
		}

	}
}