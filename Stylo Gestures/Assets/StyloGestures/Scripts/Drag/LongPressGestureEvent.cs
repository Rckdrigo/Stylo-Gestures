using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace StyloGestures
{
	[AddComponentMenu("Stylo Gestures/Long Press Gesture Event")]
	public class LongPressGestureEvent : MonoBehaviour
	{
		public UnityEvent OnLongPress;
		public static Vector2 position;

		void Start()
		{
			LongPressGesture.OnLongPressEvent += (actualPosition) =>
			{
				position = actualPosition;
				OnLongPress.Invoke();
			};
		}
	}
}
