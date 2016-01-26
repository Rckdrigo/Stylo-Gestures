using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures{

	public class DragDetectionExample : DragGesture {

		Text exampleLabel;

		void Start(){
			exampleLabel = GameObject.Find("ExampleText").GetComponent<Text>();
		}

		public override void OnDragDetected (Vector2 screenPosition, Vector2 direction)
		{
			exampleLabel.text = "Drag\nPosition: " + screenPosition + "\nDirection: " + direction;
		}

	}
}