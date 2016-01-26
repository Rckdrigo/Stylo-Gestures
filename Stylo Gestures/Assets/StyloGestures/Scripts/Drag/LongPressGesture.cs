using UnityEngine;
using UnityEngine.Assertions;

namespace StyloGestures{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Long-Press-Gesture")]
	public class LongPressGesture : MonoBehaviour {

		#region Core
		[Range(0f,1f)] public float minimumTime = 0.5f;
		private bool dragging;
		private Vector2 lastPosition,actualPosition;
		private float timeDragging;

		public virtual void FixedUpdate () {
			#if UNITY_EDITOR
			if(Input.GetMouseButton(0)){
				dragging = true;
				timeDragging += Time.deltaTime;

				actualPosition = Input.mousePosition;
				if(lastPosition!=null){
					if(lastPosition == actualPosition){
						if(timeDragging >= minimumTime)
							OnLongPressDetected(actualPosition);
					}else{
						timeDragging = 0;
					}	
				}
			}else if(!Input.GetMouseButton(0)){
				dragging = false;
				timeDragging = 0;
			}
			#else
			if(Input.touchCount == 1){
				dragging = true;
				actualPosition = Input.GetTouch(0).position;
				if(Input.GetTouch(0).phase == TouchPhase.Stationary)
					OnPressDetected(actualPosition);
			}else if(Input.touchCount == 0){
				dragging = false;
				timeDragging = 0;
			}
			#endif
		}

		public virtual void LateUpdate(){
			if(dragging){
				lastPosition = actualPosition;
			}
		}
		#endregion

		#region Public Methods
		public virtual void OnLongPressDetected(Vector2 screenPosition){}
		#endregion
	}
}
