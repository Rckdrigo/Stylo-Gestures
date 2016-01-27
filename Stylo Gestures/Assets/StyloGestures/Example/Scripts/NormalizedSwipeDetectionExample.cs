using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class NormalizedSwipeDetectionExample : SwipeGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnSwipeNormalizedDetected(Vector2 direction)
		{
			exampleLabel.text = "Swipe\nNormalized direction: " + direction;
		}

	}
}
