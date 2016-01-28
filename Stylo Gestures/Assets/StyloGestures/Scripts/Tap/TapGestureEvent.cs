using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace StyloGestures
{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Tap-Gesture#unity-events")]
	[AddComponentMenu("Stylo Gestures/Tap Gesture Event")]
	public class TapGestureEvent : MonoBehaviour
	{
		public UnityEvent OnTap;
		public static Vector2 lastTapPosition;

		void Start()
		{
			TapGesture.OnTapEvent += (actualPosition) =>
			{
				lastTapPosition = actualPosition;
				OnTap.Invoke();
			};
		}

	}
}