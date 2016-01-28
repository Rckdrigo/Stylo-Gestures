using UnityEngine;
using System.Collections;
using System;

namespace StyloGestures
{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Long-Press-Gesture")]
	public abstract class LongPressGesture : Gesture
	{

		#region Core

		public delegate void OnGestureEvent(Vector2 actualPosition);

		public static event OnGestureEvent OnLongPressEvent;

		[Range(0f, 1f)] public float minimumTime = 0.5f;
		private Vector2 actualPosition;
		private float timeDragging;

		#if UNITY_EDITOR
		private Vector2 lastPosition;
		private bool dragging;
		#endif

		public virtual void FixedUpdate()
		{
			#if UNITY_EDITOR
			if (Input.GetMouseButton(0))
			{
				dragging = true;
				timeDragging += Time.deltaTime;

				actualPosition = Input.mousePosition;
				if (lastPosition == actualPosition)
				{
					if (timeDragging >= minimumTime)
					{
						onGesture = true;
						OnLongPressDetected(actualPosition);
						try
						{
							OnLongPressEvent(actualPosition);
						}
						catch (NullReferenceException)
						{
						}
					}
				}
				else
				{
					timeDragging = 0;
					onGesture = false;
				}	
				
			}
			else if (!Input.GetMouseButton(0))
			{
				dragging = false;
				onGesture = false;
				timeDragging = 0;
			}
			#else
			if (Input.touchCount == 1)
			{
				timeDragging += Time.deltaTime;
				actualPosition = Input.GetTouch(0).position;
				if (Input.GetTouch(0).phase == TouchPhase.Stationary)
				{
					if (timeDragging >= minimumTime)
					{
						onGesture = true;
						OnLongPressDetected(actualPosition);
                        try
                        {
                            OnLongPressEvent(actualPosition);
                        }
                        catch (NullReferenceException)
                        {
                        }
					}
				}
				else
				{
					onGesture = false;
				}
			}
			else if (Input.touchCount == 0)
			{
				timeDragging = 0;
				onGesture = false;
			}
			#endif
		}

		#if UNITY_EDITOR
		public virtual void LateUpdate()
		{
			if (dragging)
			{
				lastPosition = actualPosition;
			}
		}
		#endif
		#endregion

		#region Public Methods

		public virtual void OnLongPressDetected(Vector2 actualPosition)
		{
		}

		#endregion
	}
}
