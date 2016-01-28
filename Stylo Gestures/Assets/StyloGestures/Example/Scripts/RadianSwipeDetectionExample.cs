using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class RadianSwipeDetectionExample : SwipeGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnSwipeRadianDetected(float angle, float radius)
		{
			exampleLabel.text = "Swipe\nRadian Angle: " + angle + "\nRadius: " + radius;
		}

	}
}
