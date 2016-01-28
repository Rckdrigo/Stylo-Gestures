using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class LongPressDetectionExample : LongPressGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnLongPressDetected(Vector2 actualPosition)
		{
			exampleLabel.text = "Long Press\nPosition: " + actualPosition;
		}

	}
}