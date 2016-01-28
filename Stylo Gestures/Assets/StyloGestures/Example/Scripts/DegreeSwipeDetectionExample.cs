using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class DegreeSwipeDetectionExample : SwipeGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnSwipeDegreeDetected(float angle, float radius)
		{
			exampleLabel.text = "Swipe\nDegree Angle: " + angle + "\nRadius: " + radius;
		}
	}
}
