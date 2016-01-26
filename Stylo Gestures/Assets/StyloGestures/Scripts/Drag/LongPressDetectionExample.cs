using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures{

	public class LongPressDetectionExample : LongPressGesture {

		Text exampleLabel;

		void Start(){
			exampleLabel = GameObject.Find("ExampleText").GetComponent<Text>();
		}

		public override void OnLongPressDetected (Vector2 screenPosition)
		{
			exampleLabel.text = "Long Press\nPosition: " + screenPosition;
		}

	}
}