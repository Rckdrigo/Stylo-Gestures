using UnityEngine;
using System.Collections;
using System;

namespace StyloGestures
{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Drag-Gesture")]
	public abstract class DragGesture : Gesture
	{

		#region Core

		public delegate void OnGestureEvent(Vector2 actualPosition,Vector2 actualDirection);

		public static event OnGestureEvent OnDragEvent;

		private bool dragging;
		private Vector2 lastPosition, actualPosition;

		public virtual void FixedUpdate()
		{
			#if UNITY_EDITOR
			if (Input.GetMouseButton(0))
			{
				dragging = true;
				actualPosition = Input.mousePosition;
				onGesture = true;
				OnDragDetected(actualPosition, (actualPosition - lastPosition).normalized);
				try
				{
					OnDragEvent(actualPosition, (actualPosition - lastPosition).normalized);
				}
				catch (NullReferenceException)
				{
				}
			}
			else if (!Input.GetMouseButton(0))
			{
				onGesture = false;
				dragging = false;
			}
			#else
			if (Input.touchCount == 1)
			{
				dragging = true;
				actualPosition = Input.GetTouch(0).position;
				if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary)
				{
                    onGesture = true;
					OnDragDetected(actualPosition, (actualPosition - lastPosition).normalized);
                    try
                    {
                        OnDragEvent(actualPosition, (actualPosition - lastPosition).normalized);
                    }
                    catch (NullReferenceException)
                    {
                    }
				}
			}
			else if (Input.touchCount == 0)
			{
                onGesture = false;
				dragging = false;
			}
			#endif
		}

		public virtual void LateUpdate()
		{
			if (dragging)
			{
				lastPosition = actualPosition;
			}
		}

		#endregion

		#region Public Methods

		public virtual void OnDragDetected(Vector2 actualPosition, Vector2 actualDirection)
		{
		}

		#endregion
	}
}
