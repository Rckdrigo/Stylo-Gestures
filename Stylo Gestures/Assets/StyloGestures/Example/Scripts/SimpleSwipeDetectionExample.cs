using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class SimpleSwipeDetectionExample : SwipeGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnSwipeSimpleDetected(SwipeDirection direction)
		{
			exampleLabel.text = "Swipe\nSimple direction: " + direction;
		}

	}
}