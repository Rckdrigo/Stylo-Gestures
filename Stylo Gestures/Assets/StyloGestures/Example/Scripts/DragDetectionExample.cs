using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{

	public class DragDetectionExample : DragGesture
	{

		ExampleTextBehaviour exampleLabel;

		void Start()
		{
			exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
		}

		public override void OnDragDetected(Vector2 actualPosition, Vector2 actualDirection)
		{
			exampleLabel.text = "Drag\nPosition: " + actualPosition + "\nDirection: " + actualDirection;
		}

	}
}