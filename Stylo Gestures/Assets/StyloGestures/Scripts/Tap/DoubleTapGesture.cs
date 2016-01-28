using UnityEngine;
using System.Collections;
using System;

namespace StyloGestures
{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Double-Tap-Gesture")]
	public abstract class DoubleTapGesture : MonoBehaviour
	{
		[Range(0.00f, 0.3f)] public float timeGap = 0.25f;

		#region Core

		public delegate void OnGestureEvent();

		public static event OnGestureEvent OnDoubleTapEvent;

		private bool tapped;
		private int tapCount = 0;

		public virtual void FixedUpdate()
		{
			#if !UNITY_EDITOR
			if (Input.touchCount > 0)
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
				if (tapCount == 2)
				{
					OnDoubleTapDetected();
					try
					{
						OnDoubleTapEvent();
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

		public virtual void OnDoubleTapDetected()
		{
		}

		#endregion
	}
}