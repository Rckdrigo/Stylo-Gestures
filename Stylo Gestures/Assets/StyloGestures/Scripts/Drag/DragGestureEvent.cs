﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace StyloGestures
{
	[AddComponentMenu("Stylo Gestures/Drag Gesture Event")]
	public class DragGestureEvent : MonoBehaviour
	{
		public UnityEvent OnDrag;
		public static Vector2 position, direction;


		void Start()
		{
			DragGesture.OnDragEvent += (actualPosition, actualDirection) =>
			{
				position = actualPosition;
				direction = actualDirection;
				OnDrag.Invoke();
			};
		}

	}
}