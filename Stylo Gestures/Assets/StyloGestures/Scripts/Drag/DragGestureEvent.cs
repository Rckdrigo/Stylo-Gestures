﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace StyloGestures
{
<<<<<<< Updated upstream
	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Drag-Gesture#unity-events")]
=======
>>>>>>> Stashed changes
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