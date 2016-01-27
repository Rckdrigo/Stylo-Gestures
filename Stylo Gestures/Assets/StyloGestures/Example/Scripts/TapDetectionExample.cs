using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class TapDetectionExample : TapGesture
	{
		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnSingleTapDetected(Vector2 actualPosition)
		{ 
			exampleLabel.text = "Tap: " + actualPosition;
		}

	}
}