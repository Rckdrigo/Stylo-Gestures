using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class RawSwipeDetectionExample : SwipeGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnSwipeRawDetected(Vector2 direction)
		{
			exampleLabel.text = "Swipe\nRaw direction: " + direction;	
		}
		
	}
}