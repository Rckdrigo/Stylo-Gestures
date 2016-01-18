using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

namespace StyloGestures{
	public abstract class TapGesture : MonoBehaviour {

		[SerializeField] private GestureParameters gestureParameters;

		#region Core
		private bool tapped;
		private int tapCount = 0;

		public virtual void Start (){
			Assert.IsNotNull(gestureParameters,"You must use a gesture parameters asset.\nYou can use either the default parameters in Assets/StyloGestures/Resources/DefaultGestureParameters.asset or create a new asset with Stylo Gestures/Create gesture parameters in the option bars.");
		}
		
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
			yield return new WaitForSeconds(gestureParameters.tapDeltaTime);
			#if !UNITY_EDITOR
			if((Input.touchCount == 0))
			#else
			if(!Input.GetMouseButton(0))
			#endif
			{
				if(tapCount > 1)
					DoubleTapDetected();
				else 
					SingleTapDetected();
			}
			tapCount = 0;
		}

		#endregion

		#region Public Methods
		public virtual void SingleTapDetected(){}
		public virtual void DoubleTapDetected(){}
		#endregion
	}


}