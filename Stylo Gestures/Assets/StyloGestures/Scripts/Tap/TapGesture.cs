﻿using UnityEngine;
using System.Collections;

namespace StyloGestures{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Tap-Gesture")]
	public abstract class TapGesture : MonoBehaviour {

		[Range(0.00f,0.2f)] public float timeGap = 0.15f;

		#region Core

		private bool tapped;
		private int tapCount = 0;

		public virtual void Update () {
			#if !UNITY_EDITOR
			if(Input.touchCount == 1){
				if(Input.GetTouch(0).phase == TouchPhase.Began){
					tapCount++;
					StopCoroutine("CheckIfGesture");
					StartCoroutine("CheckIfGesture");
				}
			}
			#else
			if(Input.GetMouseButtonDown(0)){
				tapCount++;
				StopCoroutine("CheckIfGesture");
				StartCoroutine("CheckIfGesture");
			}
			#endif
		}


		private IEnumerator CheckIfGesture(){
			yield return new WaitForSeconds(timeGap);
			#if !UNITY_EDITOR
			if((Input.touchCount == 0))
			#else
			if(!Input.GetMouseButton(0))
			#endif
			{
				if(tapCount == 1)
					SingleTapDetected();
			}
			tapCount = 0;
		}

		#endregion

		#region Public Methods
		public virtual void SingleTapDetected(){}
		#endregion
	}


}