using UnityEngine;
using System;
using System.Collections;

namespace StyloGestures
{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Tap-Gesture")]
	public abstract class TapGesture : Gesture
	{

		[Range(0.00f, 0.2f)] public float timeGap = 0.15f;

		#region Core

		private bool tapped;
		private int tapCount = 0;


		public delegate void OnGestureEvent(Vector2 actualPosition);

		public static event OnGestureEvent OnTapEvent;


		public virtual void FixedUpdate()
		{
			#if !UNITY_EDITOR
            if (Input.touchCount == 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    tapCount++;
                    StopCoroutine("CheckIfGesture");
                    StartCoroutine("CheckIfGesture");
                }
            }
			#else
			if (Input.GetMouseButtonDown(0))
			{
				tapCount++;
				StopCoroutine("CheckIfGesture");
				StartCoroutine("CheckIfGesture");
			}
			#endif
		}


		private IEnumerator CheckIfGesture()
		{
			yield return new WaitForSeconds(timeGap);
			#if !UNITY_EDITOR
			if((Input.touchCount == 0))
			#else
			if (!Input.GetMouseButton(0))
			#endif
			{
				if (tapCount == 1)
				{
					#if UNITY_EDITOR
					OnSingleTapDetected(Input.mousePosition);
					#elif
                    OnSingleTapDetected(Input.GetTouch(0).position);

					#endif
					try
					{
						#if UNITY_EDITOR
						OnTapEvent(Input.mousePosition);
						#elif
                        OnTapEvent(Input.GetTouch(0).position);
						#endif
					}
					catch (NullReferenceException)
					{
					}

				}
			}
			tapCount = 0;
		}

		#endregion

		#region Public Methods

		public virtual void OnSingleTapDetected(Vector2 actualPosition)
		{
		}

		#endregion
	}


}