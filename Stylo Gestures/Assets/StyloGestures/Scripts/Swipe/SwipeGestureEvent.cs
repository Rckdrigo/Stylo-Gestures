using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace StyloGestures
{
	[AddComponentMenu("Stylo Gestures/Swipe Gesture Event")]
	public class SwipeGestureEvent : MonoBehaviour
	{
		public UnityEvent OnSwipe;
		public static SwipeDirection actualSwipeDirection;
		public static Vector2 actualDirection;
		public static float actualDegreeAngle, actualRadianAngle, actualRadius;

		void Start()
		{
			SwipeGesture.OnSwipeEvent += (SwipeDirection swipeDirection, Vector2 direction, float degreeAngle, float radianAngle, float radius) =>
			{
				actualSwipeDirection = swipeDirection;
				actualDirection = direction;
				actualDegreeAngle = degreeAngle;
				actualRadianAngle = radianAngle;
				actualRadius = radius;
				OnSwipe.Invoke();
			};
		}
	}
}