using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace StyloGestures
{
	[AddComponentMenu("Stylo Gestures/Double Tap Gesture Event")]
	public class DoubleTapGestureEvent : MonoBehaviour
	{
		public UnityEvent OnDoubleTap;

		void Start()
		{
			DoubleTapGesture.OnDoubleTapEvent += () =>
			{
				OnDoubleTap.Invoke();
			};
		}
	}
}
