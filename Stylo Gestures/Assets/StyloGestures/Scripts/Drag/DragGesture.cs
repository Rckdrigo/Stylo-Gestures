using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

namespace StyloGestures{

	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Drag-Gesture")]
	public class DragGesture : MonoBehaviour {

		#region Core
		private bool dragging;
		private Vector2 lastPosition,actualPosition;

		public virtual void FixedUpdate () {
			#if UNITY_EDITOR
			if(Input.GetMouseButton(0)){
				dragging = true;
				actualPosition = Input.mousePosition;
				if(lastPosition!=null){
						OnDragDetected(actualPosition,(actualPosition-lastPosition).normalized);
				}
			}else if(!Input.GetMouseButton(0)){
				dragging = false;
			}
			#else
			if(Input.touchCount == 1){
				dragging = true;
				actualPosition = Input.GetTouch(0).position;
				if(Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary){
					if(lastPosition!=null)
						OnDraggingDetected(actualPosition,(actualPosition-lastPosition).normalized);
				}
			}else if(Input.touchCount == 0){
				dragging = false;
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
		public virtual void OnDragDetected(Vector2 screenPosition, Vector2 direction){}
		#endregion
	}
}
